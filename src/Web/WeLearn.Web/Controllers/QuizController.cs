using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Data.Models.Quiz;

using WeLearn.Services.Data;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Examination;
using WeLearn.Web.ViewModels.Question;
using WeLearn.Web.ViewModels.Quiz;

namespace WeLearn.Web.Controllers
{
    public class QuizController : BaseController
    {
        private readonly IQuestionsService questionsService;
        private readonly IQuizzesService quizzesService;
        private readonly IExaminationsService examinationsService;
        private readonly IChoicesService choicesService;

        public QuizController(
            IQuestionsService questionsService,
            IQuizzesService quizzesService,
            IExaminationsService examinationsService,
            IChoicesService choicesService)
        {
            this.questionsService = questionsService;
            this.quizzesService = quizzesService;
            this.examinationsService = examinationsService;
            this.choicesService = choicesService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult All()
        {
            var models = this.quizzesService
                .GetAll<QuizViewModel>()
                .ToArray();

            // todo: pagination
            return this.View(models);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Dashboard()
        {
            var userId = this.GetUserId();

            var models = this.examinationsService
                .GetAll<ExaminationViewModel>()
                .Where(x => x.UserId == userId);

            // todo: pagination
            return this.View(models);
        }

        [HttpGet]
        [Authorize]
        public IActionResult View(int id)
        {
            bool examinationExists = this.examinationsService
                .Contains(id);

            bool isViewingAllowed = this.examinationsService
                .GetById(id)
                .UserId == this.GetUserId();

            if (!examinationExists || !isViewingAllowed)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            var examination = this.examinationsService.GetById<ExaminationViewModel>(id);
            examination!.Questions = this.questionsService
                .GetAll<QuestionViewModel>()
                .Where(question => question.Quizzes
                    .Any(quiz => quiz.Id == examination.QuizId));

            return this.View(examination);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Take(int id)
        {
            var quiz = this.quizzesService
                .GetById<QuizTakingInputModel>(id)
                .FirstOrDefault();

            if (quiz == null)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            quiz.Questions = quiz.Questions
                .OrderBy(_ => Guid.NewGuid())
                .ToList();

            foreach (var questionModel in quiz.Questions)
            {
                questionModel.Answers = questionModel.Answers
                    .OrderBy(_ => Guid.NewGuid())
                    .ToList();
            }

            return this.View(quiz);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Take(IFormCollection formCollection)
        {
            List<Choice> choices = new List<Choice>();
            bool notValid = false;

            int quizId = int.Parse(formCollection["quizId"]);
            int points = 0;

            string[] questionIds = formCollection["questionId"];
            string userId = this.GetUserId();

            questionIds.ToList().ForEach(id =>
            {
                if (!int.TryParse(formCollection["question_" + id], out _))
                {
                    notValid = true;
                }
            });

            if (notValid)
            {
                return this.RedirectToAction(nameof(this.Take), new { id = quizId });
            }

            foreach (var questionId in questionIds)
            {
                int questionIdParsed = int.Parse(questionId);
                int? answerIdCorrect = this.questionsService
                    .GetAllWithAnswers()
                    .FirstOrDefault(q => q.Id == questionIdParsed)
                    ?.Answers
                        .FirstOrDefault(a => a.IsCorrect)
                        ?.Id;

                int userAnswerId = int.Parse(formCollection["question_" + questionId]);
                if (answerIdCorrect == userAnswerId)
                {
                    var questionPoints = this.questionsService
                        .GetAllWithAnswers()
                        .First(q => q.Id == questionIdParsed)
                        .Points;

                    points += questionPoints;
                }

                if (answerIdCorrect == null)
                {
                    return null;
                }

                var choice = await this.choicesService.CreateAsync(int.Parse(questionId), userAnswerId);
                choices.Add(choice);
            }

            await this.examinationsService.CreateAsync(quizId, points, userId, choices);
            await this.choicesService.SaveChangesAsync();

            return this.RedirectToAction(nameof(this.Dashboard));
        }
    }
}

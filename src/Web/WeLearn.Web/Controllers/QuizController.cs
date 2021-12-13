using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Quiz;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Examination;
using WeLearn.Web.ViewModels.Quiz;

namespace WeLearn.Web.Controllers
{
    public class QuizController : BaseController
    {
        // todo: interface instead of class
        private readonly QuestionsService questionsService;
        private readonly ICategoriesService categoriesService;
        private readonly QuizzesService quizzesService;
        private readonly ExaminationsService examinationsService;

        private readonly IDeletableEntityRepository<Examination> examinationRepo;

        public QuizController(
            QuestionsService questionsService,
            ICategoriesService categoriesService,
            QuizzesService quizzesService,
            ExaminationsService examinationsService,

            // todo: use but behind a service, refactor
            IDeletableEntityRepository<Examination> examinationRepo)
        {
            this.questionsService = questionsService;
            this.categoriesService = categoriesService;
            this.quizzesService = quizzesService;
            this.examinationsService = examinationsService;

            this.examinationRepo = examinationRepo;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Dashboard()
        {
            // todo:
            // var randomQuiz = this.quizzesService.GetQuizById(4)
            //     .Questions.Sum(q => q.Answers.Where(a => a.IsCorrect && a.QuestionId == q.Id)
            //         .Sum(a => a.Question.Points));
            var userId = this.GetUserId();

            var allQuizzesViewModels = this.quizzesService.GetAll<QuizViewModel>();

            var takenQuizzesViewModels = this.examinationsService
                .GetAll<ExaminationViewModel>()
                .Where(x => x.ApplicationUserId == userId);

            var model = new QuizDashboardModel
            {
                AllQuizzesViewModels = allQuizzesViewModels,
                ExaminationViewModels = takenQuizzesViewModels,
            };

            return this.View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult View(int id)
        {
            // todo:
            // var randomQuiz = this.quizzesService.GetQuizById(4)
            //     .Questions.Sum(q => q.Answers.Where(a => a.IsCorrect && a.QuestionId == q.Id)
            //         .Sum(a => a.Question.Points));
            var examination = this.examinationsService.GetById<ExaminationViewModel>(id).FirstOrDefault();

            return this.View(examination);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Take(int id)
        {
            // todo:
            // var randomQuiz = this.quizzesService.GetQuizById(4)
            //     .Questions.Sum(q => q.Answers.Where(a => a.IsCorrect && a.QuestionId == q.Id)
            //         .Sum(a => a.Question.Points));
            var quiz = this.quizzesService.GetById<QuizTakingInputModel>(id).FirstOrDefault();

            return this.View(quiz);
        }

        // public IActionResult Take(QuizTakingInputModel model)
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Take(IFormCollection formCollection)
        {
            int points = 0;
            string userId = this.GetUserId();
            int quizId = int.Parse(formCollection["quizId"]);

            // todo credit
            // https://www.youtube.com/watch?v=msRJdf5AfoI
            string[] questionIds = formCollection["questionId"];

            foreach (var questionId in questionIds)
            {
                int questionIdParsed = int.Parse(questionId);

                int? answerIdCorrect = this.questionsService
                    .GetAllQuestions()
                    .FirstOrDefault(q => q.Id == questionIdParsed)
                    ?.Answers
                        .FirstOrDefault(a => a.IsCorrect)
                        ?.Id;

                if (answerIdCorrect == int.Parse(formCollection["question_" + questionId]))
                {
                    var questionPoints = this.questionsService
                        .GetAllQuestions()
                        .First(q => q.Id == questionIdParsed)
                        .Points;

                    points += questionPoints;
                }
            }

            var examination = new Examination
            {
                QuizId = quizId,
                Points = points,
                ApplicationUserId = userId,
            };

            await this.examinationRepo.AddAsync(examination);
            await this.examinationRepo.SaveChangesAsync();

            return this.RedirectToAction(nameof(this.Dashboard));
        }
    }
}

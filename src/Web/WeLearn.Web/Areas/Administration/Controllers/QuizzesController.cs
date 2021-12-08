using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Admin.Lesson;
using WeLearn.Web.ViewModels.HelperModels;
using WeLearn.Web.ViewModels.Question;
using WeLearn.Web.ViewModels.Quiz;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class QuizzesController : AdministrationController
    {
        // todo: interface instead of class
        private readonly QuestionsService questionsService;
        private readonly ICategoriesService categoriesService;
        private readonly QuizzesService quizzesService;

        public QuizzesController(
            QuestionsService questionsService,
            ICategoriesService categoriesService,
            QuizzesService quizzesService)
        {
            this.questionsService = questionsService;
            this.categoriesService = categoriesService;
            this.quizzesService = quizzesService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // var randomQuiz = this.quizzesService.GetQuizById(4)
            //     .Questions.Sum(q => q.Answers.Where(a => a.IsCorrect && a.QuestionId == q.Id)
            //         .Sum(a => a.Question.Points));

            var quizzes = this.quizzesService.GetAll<QuizViewModel>();
            return this.View(quizzes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            QuizInputModel model = new QuizInputModel
            {
                Categories = this.categoriesService.GetAllCategories(),
                Questions = this.questionsService.GetAll<QuestionViewModel>().ToList(),
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(QuizInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.quizzesService.CreateAsync(model);
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = this.quizzesService
                .GetById<QuizEditModel>(id)
                .FirstOrDefault();

            if (model == null)
            {
                return this.RedirectToAction(nameof(this.Index));
            }

            model.Categories = this.categoriesService.GetAllCategories();
            model.Questions = this.questionsService.GetAll<QuestionViewModel>().ToList();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = this.quizzesService.Contains(id);

            if (!exists)
            {
                return this.RedirectToAction(nameof(this.Index));
            }

            await this.quizzesService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.Index));
        }

        // [HttpGet]
        // public IActionResult Index()
        // {
        //     // IEnumerable<AdminReportViewModel> reports = await this.quizzesService.GetAllReportsAsync<AdminReportViewModel>(searchString);
        //     // paginated.SearchString = searchString;
        //
        //     return View();
        // }
    }
}

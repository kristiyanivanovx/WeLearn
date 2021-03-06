using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WeLearn.Services.Data;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.Examination;
using WeLearn.Web.ViewModels.Question;
using WeLearn.Web.ViewModels.Quiz;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(SystemAdministrationAreaName)]
    [Authorize(Roles = SystemRegularAdministratorRoleName + "," + SystemTeacherRoleName)]
    public class QuizzesController : Controller
    {
        private readonly IExaminationsService examinationsService;
        private readonly IQuestionsService questionsService;
        private readonly ICategoriesService categoriesService;
        private readonly IQuizzesService quizzesService;

        public QuizzesController(
            IExaminationsService examinationsService,
            IQuestionsService questionsService,
            ICategoriesService categoriesService,
            IQuizzesService quizzesService)
        {
            this.examinationsService = examinationsService;
            this.questionsService = questionsService;
            this.categoriesService = categoriesService;
            this.quizzesService = quizzesService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var quizzes = this.quizzesService.GetAll<QuizViewModel>();
            return this.View(quizzes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            QuizInputModel model = new QuizInputModel
            {
                Categories = this.categoriesService.GetAll<CategoryViewModel>(),
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

            model.Categories = this.categoriesService.GetAll<CategoryViewModel>();
            model.Questions = this.questionsService.GetAll<QuestionViewModel>().ToList();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(QuizEditModel model)
        {
            await this.quizzesService.EditAsync(model);
            return this.RedirectToAction(nameof(this.Index));
        }

        public IActionResult Examinations()
        {
            var models = this.examinationsService
                .GetAll<ExaminationViewModel>();

            return this.View(models);
        }

        [HttpGet]
        public IActionResult View(int id)
        {
            bool examinationExists = this.examinationsService.Contains(id);
            if (!examinationExists)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            var examination = this.examinationsService.GetById<ExaminationViewModel>(id);
            if (examination != null)
            {
                examination.Questions = this.questionsService
                    .GetAll<QuestionViewModel>()
                    .Where(question => question.Quizzes
                        .Any(quiz => quiz.Id == examination.QuizId));
            }

            return this.View(examination);
        }

        [Authorize(Roles = SystemRegularAdministratorRoleName)]
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
    }
}

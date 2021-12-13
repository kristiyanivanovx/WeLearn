using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using WeLearn.Data.Models;
using WeLearn.Services;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class QuestionsController : AdministrationController
    {
        // todo: interface instead of class
        private readonly AnswersService answersService;
        private readonly QuestionsService questionsService;

        public QuestionsController(AnswersService answersService, QuestionsService questionsService)
        {
            this.answersService = answersService;
            this.questionsService = questionsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var models = this.questionsService.GetAll<QuestionViewModel>();
            return this.View(models);
        }

        [HttpGet]
        public IActionResult Create()
        {
            QuestionInputModel model = new QuestionInputModel();
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(QuestionInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.questionsService.CreateAsync(model);
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = this.questionsService
                .GetById<QuestionEditModel>(id)
                .FirstOrDefault();

            // todo
            if (model == null)
            {
                return null;
            }

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(QuestionEditModel model)
        {
            var exists = this.questionsService.Contains(model.Id);

            // todo
            if (!exists)
            {
                return null;
            }

            await this.questionsService.EditAsync(model);

            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.questionsService.DeleteAsync(id);
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

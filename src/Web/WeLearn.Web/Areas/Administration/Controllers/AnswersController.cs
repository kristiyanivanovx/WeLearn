using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WeLearn.Services.Data;
using WeLearn.Web.ViewModels.Answer;
using WeLearn.Web.ViewModels.Question;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(SystemAdministrationAreaName)]
    [Authorize(Roles = SystemRegularAdministratorRoleName + "," + SystemTeacherRoleName)]
    public class AnswersController : Controller
    {
        // todo: interface instead of class
        private readonly AnswersService answersService;
        private readonly QuestionsService questionsService;

        public AnswersController(AnswersService answersService, QuestionsService questionsService)
        {
            this.answersService = answersService;
            this.questionsService = questionsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var models = this.answersService.GetAll<AnswerViewModel>();
            return this.View(models);
        }

        [HttpGet]
        public IActionResult Create()
        {
            AnswerInputModel model = new AnswerInputModel
            {
                Questions = this.questionsService.GetAll<QuestionViewModel>(),
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AnswerInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.answersService.CreateAsync(model);
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = this.answersService.GetById<AnswerEditModel>(id);
            if (model == null)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            model.Questions = this.questionsService.GetAll<QuestionViewModel>();
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AnswerEditModel model)
        {
            var exists = this.answersService.Contains(model.Id);
            if (!this.ModelState.IsValid || !exists)
            {
                return this.View(model);
            }

            await this.answersService.EditAsync(model);
            return this.RedirectToAction(nameof(this.Index));
        }

        [Authorize(Roles = SystemRegularAdministratorRoleName)]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = this.answersService.Contains(id);
            if (!exists)
            {
                return this.RedirectToAction(nameof(this.Index));
            }

            await this.answersService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

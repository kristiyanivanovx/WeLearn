using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WeLearn.Services.Data;
using WeLearn.Web.ViewModels.Question;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(SystemAdministrationAreaName)]
    [Authorize(Roles = SystemRegularAdministratorRoleName + "," + SystemTeacherRoleName)]
    public class QuestionsController : Controller
    {
        // todo: interface instead of class
        private readonly QuestionsService questionsService;

        public QuestionsController(QuestionsService questionsService)
        {
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
            var model = this.questionsService.GetById<QuestionEditModel>(id);

            if (model == null)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(QuestionEditModel model)
        {
            var exists = this.questionsService.Contains(model.Id);
            if (!exists)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            await this.questionsService.EditAsync(model);

            return this.RedirectToAction(nameof(this.Index));
        }

        [Authorize(Roles = SystemRegularAdministratorRoleName)]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = this.questionsService.Contains(id);
            if (!exists)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            await this.questionsService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

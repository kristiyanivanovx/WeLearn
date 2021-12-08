using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Services;
using WeLearn.Web.ViewModels.Answer;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class AnswersController : AdministrationController
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
            // todo: not found
            var model = this.answersService.GetById<AnswerEditModel>(id).FirstOrDefault();
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

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = this.answersService.Contains(id);

            if (!exists)
            {
                return this.RedirectToAction(nameof(this.Index));
            }

            await this.answersService.Delete(id);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

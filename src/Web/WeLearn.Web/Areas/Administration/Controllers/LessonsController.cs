using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Admin.Lesson;
using WeLearn.Web.ViewModels.HelperModels;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class LessonsController : AdministrationController
    {
        private readonly ILessonsService lessonsService;
        private readonly ICategoriesService categoriesService;

        public LessonsController(ILessonsService lessonsService, ICategoriesService categoriesService)
        {
            this.lessonsService = lessonsService;
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            var lessonsViewModels =
                await this.lessonsService.GetAllLessonsWithDeletedAsync<AdminLessonViewModel>(searchString);

            var paginated = PaginatedList<AdminLessonViewModel>.Create(
                    lessonsViewModels.OrderBy(x => x.IsApproved),
                    pageNumber ?? 1,
                    6);

            paginated.SearchString = searchString;

            return this.View(paginated);
        }

        public async Task<IActionResult> Edit(int id)
        {
            AdminLessonEditModel lesson =
                await this.lessonsService.GetLessonByIdWithDeletedAsync<AdminLessonEditModel>(id);

            lesson.Categories = this.categoriesService.GetAllCategories();

            return this.View(lesson);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdminLessonEditModel lessonModel)
        {
            if (!this.ModelState.IsValid)
            {
                // lessonModel.Categories = this.categoriesService.GetAllCategories();
                return this.View(lessonModel);
            }

            await this.lessonsService.EditLessonAdministrationAsync(lessonModel);
            return this.RedirectToAction(nameof(this.Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var lesson = await this.lessonsService.GetLessonByIdWithDeletedAsync<AdminLessonDeleteModel>(id);
            return this.View(lesson);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.lessonsService.HardDeleteLessonByIdAsync(id);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Admin.Lesson;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.HelperModels;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(SystemAdministrationAreaName)]
    [Authorize(Roles = SystemRegularAdministratorRoleName + "," + SystemTeacherRoleName)]
    public class LessonsController : Controller
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
            AdminLessonEditModel lesson = await this.lessonsService.GetLessonByIdWithDeletedAsync<AdminLessonEditModel>(id);
            lesson.Categories = this.categoriesService.GetAll<CategoryViewModel>();

            return this.View(lesson);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdminLessonEditModel lessonModel)
        {
            if (!this.ModelState.IsValid)
            {
                // lessonModel.Categories = this.categoriesService.GetAllCategories<CategoryViewModel>();
                return this.View(lessonModel);
            }

            await this.lessonsService.EditLessonAdministrationAsync(lessonModel);
            return this.RedirectToAction(nameof(this.Index));
        }

        [Authorize(Roles = SystemRegularAdministratorRoleName)]
        public async Task<IActionResult> Delete(int id)
        {
            var lesson = await this.lessonsService.GetLessonByIdWithDeletedAsync<AdminLessonDeleteModel>(id);
            return this.View(lesson);
        }

        [HttpPost]
        [Authorize(Roles = SystemRegularAdministratorRoleName)]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.lessonsService.HardDeleteLessonByIdAsync(id);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

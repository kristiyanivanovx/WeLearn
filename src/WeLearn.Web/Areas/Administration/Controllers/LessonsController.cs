using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels.Admin.Lesson;
using WeLearn.ViewModels.Category;
using WeLearn.ViewModels.HelperModels;

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
            var lessonsViewModels = await this.lessonsService.GetAllLessonsAdministrationAsync<AdminLessonViewModel>(searchString);
            var paginated = PaginatedList<AdminLessonViewModel>.Create(lessonsViewModels.OrderBy(x => x.IsApproved), pageNumber ?? 1, 6);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var lesson = await this.lessonsService.GetLessonByIdAdministrationAsync<AdminLessonEditModel>(id);
            IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name", lesson.CategoryId);
            return View(lesson);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdminLessonEditModel lessonModel)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name", lessonModel.CategoryId);
                return View(lessonModel);
            }

            await this.lessonsService.EditLessonAdministrationAsync(lessonModel);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var lesson = await this.lessonsService.GetLessonByIdAdministrationAsync<AdminLessonDeleteModel>(id);
            return View(lesson);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.lessonsService.HardDeleteLessonByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

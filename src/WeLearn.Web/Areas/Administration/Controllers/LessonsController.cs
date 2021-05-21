using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;
using WeLearn.ViewModels.HelperModels;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Admin")]
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
            var lessonsViewModels = await this.lessonsService.GetAllLessonsAdministrationAsync<AdministrationLessonModel>(searchString);
            var paginated = PaginatedList<AdministrationLessonModel>.Create(lessonsViewModels.OrderBy(x => x.IsApproved), pageNumber ?? 1, 6);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var lesson = await this.lessonsService.GetLessonByIdAdministrationAsync<AdministrationLessonModel>(id);
            IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name", lesson.CategoryId);
            return View(lesson);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdministrationLessonModel lessonModel)
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
            var lesson = await this.lessonsService.GetLessonByIdAdministrationAsync<AdministrationLessonModel>(id);
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

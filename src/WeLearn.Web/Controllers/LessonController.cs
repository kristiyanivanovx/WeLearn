using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.ViewModels;
using WeLearn.Services.Interfaces;
using WeLearn.Services.HelperModels;
using System.Collections.Generic;
using static WeLearn.Data.Infrastructure.DataValidation.Video;
using static WeLearn.Data.Infrastructure.DataValidation.Material;
using WeLearn.ViewModels.HelperModels;
using System.Linq;
using Microsoft.Extensions.Hosting;
using WeLearn.Web.Controllers;
using WeLearn.Web.Infrastructure;
using WeLearn.ViewModels.Lesson;
using WeLearn.ViewModels.Category;
using WeLearn.Data.Models.Enums;
using System;

namespace WeLearn.Controllers
{
    public class LessonController : BaseController
    {
        private readonly int DefaultPageNumber = 1;
        private readonly int DefaultPageSize = 6;

        private readonly ICategoriesService categoriesService;
        private readonly ILessonsService lessonsService;
        private readonly IFileDownloadService fileDownloadService;
        private readonly IWebHostEnvironment environment;

        public LessonController(
            ICategoriesService categoriesService,
            ILessonsService lessonsService,
            IFileDownloadService fileDownloadService,
            IWebHostEnvironment environment) 
        {
            this.categoriesService = categoriesService;
            this.lessonsService = lessonsService;
            this.fileDownloadService = fileDownloadService;
            this.environment = environment;
        }

        [HttpGet]
        public IActionResult Index() => RedirectToAction(nameof(All));

        [HttpGet]
        public async Task<IActionResult> All(string searchString, int? pageNumber)
        {
            var lessonsViewModels = await this.lessonsService.GetAllLessonsAsync<LessonViewModel>(searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(lessonsViewModels.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Watch(int id)
        {
            LessonViewModel lessonViewModel = await this.lessonsService.GetLessonByIdAsync<LessonViewModel>(id);
            return View(lessonViewModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task<IActionResult> Create(LessonInputModel lessonInputModel)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name", lessonInputModel.CategoryId);
                return View(lessonInputModel);
            }

            await this.lessonsService.CreateLessonAsync(lessonInputModel, this.environment.WebRootPath, this.environment.IsDevelopment(), GetUserId());
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            LessonEditModel lesson = await this.lessonsService.GetLessonByIdAsync<LessonEditModel>(id);
            IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name", lesson.CategoryId);
            return View(lesson);
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task<IActionResult> Edit(LessonEditModel lessonEditModel)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<CategoryViewModel> categories = this.categoriesService.GetAllCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", lessonEditModel.CategoryId);
                return View(lessonEditModel);
            }

            if (lessonEditModel.UserId != GetUserId())
            {
                return View(nameof(Unauthorized));
            }

            await this.lessonsService.EditLessonAsync(lessonEditModel, this.environment.WebRootPath, this.environment.IsDevelopment(), GetUserId());
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            LessonDeleteModel lessonViewModel = await this.lessonsService.GetLessonByIdAsync<LessonDeleteModel>(id);
            return View(lessonViewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(LessonDeleteModel lessonViewModel)
        {
            if (lessonViewModel.ApplicationUserUserName != GetUserName())
            {
                return View("Unauthorized");
            }

            await this.lessonsService.SoftDeleteLessonByIdAsync(lessonViewModel.LessonId);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ByMe(string searchString, int? pageNumber)
        {
            IEnumerable<LessonViewModel> myLessons = await this.lessonsService.GetCreatedByMeAsync(GetUserId(), searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(myLessons.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> ByCategory(string categoryName, string searchString, int grade, int? pageNumber)
        {
            var lessons = await this.lessonsService.GetLessonsByCategoryAndGradeAsync(categoryName, searchString, grade);
            var paginated = PaginatedList<LessonViewModel>.Create(lessons.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
            paginated.Grade = Enum.Parse<Grade>(grade.ToString());
            paginated.CategoryName = categoryName;
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public IActionResult Download([FromQuery] string link)
        {
            FileDownload fileParsed = this.fileDownloadService.DownloadFile(link);
            return File(fileParsed.Content, fileParsed.ContentType, fileParsed.FileName);
        }
    }
}

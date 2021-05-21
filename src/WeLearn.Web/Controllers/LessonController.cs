﻿using Microsoft.AspNetCore.Authorization;
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
using static WeLearn.Data.DataValidation.Video;
using static WeLearn.Data.DataValidation.Material;
using WeLearn.ViewModels.HelperModels;
using System.Linq;
using Microsoft.Extensions.Hosting;
using WeLearn.Web.Controllers;
using WeLearn.Web.Infrastructure;

namespace WeLearn.Controllers
{
    public class LessonController : BaseController
    {
        private readonly int DefaultPageNumber = 1;
        private readonly int DefaultPageSize = 6;

        private readonly UserManager<ApplicationUser> userManager;
        private readonly ICategoriesService categoriesService;
        private readonly ILessonsService lessonsService;
        private readonly IFileDownloadService fileDownloadService;
        private readonly IWebHostEnvironment environment;
        private readonly IHttpContextAccessor httpContextAccessor;

        public LessonController(
            UserManager<ApplicationUser> userManager,
            ICategoriesService categoriesService,
            ILessonsService lessonsService,
            IFileDownloadService fileDownloadService,
            IWebHostEnvironment environment,
            IHttpContextAccessor httpContextAccessor) 
        {
            this.userManager = userManager;
            this.categoriesService = categoriesService;
            this.lessonsService = lessonsService;
            this.fileDownloadService = fileDownloadService;
            this.environment = environment;
            this.httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Index() => RedirectToAction(nameof(All));

        [HttpGet]
        public async Task<IActionResult> All(string searchString, int? pageNumber)
        {
            var lessonsViewModels = await lessonsService.GetAllLessonsAsync<LessonViewModel>(searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(lessonsViewModels.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> Watch(int id)
        {
            LessonViewModel lessonViewModel = await lessonsService.GetLessonByIdAsync<LessonViewModel>(id);
            return View(lessonViewModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            IEnumerable<CategoryViewModel> categories = categoriesService.GetAllCategories();
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
                IEnumerable<CategoryViewModel> categories = categoriesService.GetAllCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name", lessonInputModel.CategoryId);
                return View(lessonInputModel);
            }

            await lessonsService.CreateLessonAsync(lessonInputModel, environment.WebRootPath, environment.IsDevelopment(), GetUserId());
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            LessonEditModel lesson = await lessonsService.GetLessonByIdAsync<LessonEditModel>(id);
            IEnumerable<CategoryViewModel> categories = categoriesService.GetAllCategories();
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
                IEnumerable<CategoryViewModel> categories = categoriesService.GetAllCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", lessonEditModel.CategoryId);
                return View(lessonEditModel);
            }

            if (GetUserId() != lessonEditModel.UserId)
            {
                return View(nameof(Unauthorized));
            }

            await lessonsService.EditLessonAsync(lessonEditModel, environment.WebRootPath, environment.IsDevelopment(), GetUserId());
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            LessonViewModel lessonViewModel = await lessonsService.GetLessonByIdAsync<LessonViewModel>(id);
            return View(lessonViewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(LessonViewModel lessonViewModel)
        {
            string userName = HttpContext.User.Identity.Name;

            if (userName != lessonViewModel.ApplicationUserUserName)
            {
                return View("Unauthorized");
            }

            await lessonsService.SoftDeleteLessonByIdAsync(lessonViewModel.LessonId);
            return RedirectToAction(nameof(ByMe));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ByMe(string searchString, int? pageNumber)
        {
            IEnumerable<LessonViewModel> myLessons = await lessonsService.GetCreatedByMeAsync(GetUserId());
            var paginated = PaginatedList<LessonViewModel>.Create(myLessons.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public async Task<IActionResult> ByCategory(string categoryName, string searchString, int? pageNumber)
        {
            var lessons = await lessonsService.GetAllLessonsByCategoryAsync(categoryName, searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(lessons.OrderByDescending(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
            paginated.CategoryName = categoryName;
            paginated.SearchString = searchString;
            return View(paginated);
        }

        [HttpGet]
        public IActionResult Download([FromQuery] string link)
        {
            FileDownload fileParsed = fileDownloadService.DownloadFile(link);
            return File(fileParsed.Content, fileParsed.ContentType, fileParsed.FileName);
        }
    }
}

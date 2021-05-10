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
using static WeLearn.Data.DataValidation.Video;
using static WeLearn.Data.DataValidation.Material;

namespace WeLearn.Controllers
{
    public class LessonController : Controller
    {
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

        public IActionResult Index() => RedirectToAction(nameof(All));

        public async Task<IActionResult> All(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            IEnumerable<LessonViewModel> lessonsViewModels = await lessonsService.GetAllLessonsAsync(searchString);
            return View(lessonsViewModels);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            IEnumerable<CategoryViewModel> categories = categoriesService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "Id", "Name");
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
                ViewData["CategoryId"] = new SelectList(categories, "Id", "Name", lessonInputModel.Id);
                return View(lessonInputModel);
            }

            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await lessonsService.CreateLessonAsync(lessonInputModel, environment.WebRootPath, environment.EnvironmentName, userId);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            LessonEditModel lesson = await lessonsService.GetLessonByIdAsync<LessonEditModel>(id);

            var categories = categoriesService.GetAllCategories();
            ViewData["CategoryId"] = new SelectList(categories, "Id", "Name", lesson.CategoryId);

            if (userId != lesson.UserId)
            {
                return View(nameof(Unauthorized));
            }

            return View(lesson);
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task<IActionResult> Edit(LessonEditModel lessonEditModel)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                var categories = categoriesService.GetAllCategories();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", lessonEditModel.CategoryId);
                return View(lessonEditModel);
            }

            if (userId != lessonEditModel.UserId)
            {
                return View(nameof(Unauthorized));
            }

            await lessonsService.EditLessonAsync(lessonEditModel, environment.WebRootPath, environment.EnvironmentName, userId);
            return View("ThankYou");
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            ApplicationUser user = await userManager.GetUserAsync(HttpContext.User);
            LessonViewModel lessonViewModel = await lessonsService.GetLessonByIdAsync<LessonViewModel>(id);

            if (user.UserName != lessonViewModel.CreatedByUserName)
            {
                return View("Unauthorized");
            }

            return View(lessonViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(LessonViewModel lessonViewModel)
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Lesson lesson = await lessonsService.GetLessonByIdAsync<Lesson>(lessonViewModel.LessonId);

            if (userId != lesson.ApplicationUserId)
            {
                return View("Unauthorized");
            }

            await lessonsService.DeleteLessonAsync(lesson);
            return View("Deleted");
        }

        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            IEnumerable<LessonViewModel> myLessons = await lessonsService.UploadedByMeAsync(userId);
            return View(myLessons);
        }

        public async Task<IActionResult> ByCategory(string categoryName, string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewData["CategoryName"] = categoryName;
            IEnumerable<LessonViewModel> lessons = await lessonsService.GetAllRelevantLessonsAsync(categoryName, searchString);
            return View(lessons);
        }

        public IActionResult Download([FromQuery] string link)
        {
            FileDownload fileParsed = fileDownloadService.DownloadFile(link);
            return File(fileParsed.Content, fileParsed.ContentType, fileParsed.FileName);
        }

        public async Task<IActionResult> Watch(int id)
        {
            LessonViewModel lessonViewModel = await lessonsService.GetLessonByIdAsync<LessonViewModel>(id);
            return View(lessonViewModel);
        }
    }
}

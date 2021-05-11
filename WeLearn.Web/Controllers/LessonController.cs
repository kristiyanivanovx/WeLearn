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
using WeLearn.ViewModels.HelperModels;
using System.Linq;

namespace WeLearn.Controllers
{
    public class LessonController : Controller
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
            ViewData["CurrentFilter"] = searchString;
            var lessonsViewModels = await lessonsService.GetAllLessonsAsync(searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(lessonsViewModels.OrderBy(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
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

            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await lessonsService.CreateLessonAsync(lessonInputModel, environment.WebRootPath, environment.EnvironmentName, userId);
            return View("ThankYou");
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
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!ModelState.IsValid)
            {
                IEnumerable<CategoryViewModel> categories = categoriesService.GetAllCategories();
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

            if (userName != lessonViewModel.CreatedByUserName)
            {
                return View("Unauthorized");
            }

            await lessonsService.SoftDeleteLessonByIdAsync(lessonViewModel.LessonId);
            return View("Deleted");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            IEnumerable<LessonViewModel> myLessons = await lessonsService.GetCreatedByMeAsync(userId);
            return View(myLessons);
        }

        [HttpGet]
        public async Task<IActionResult> ByCategory(string categoryName, string searchString, int? pageNumber)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewData["CategoryName"] = categoryName;
            var lessons = await lessonsService.GetAllLessonsByCategoryAsync(categoryName, searchString);
            var paginated = PaginatedList<LessonViewModel>.Create(lessons.OrderBy(x => x.LessonId), pageNumber ?? DefaultPageNumber, DefaultPageSize);
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

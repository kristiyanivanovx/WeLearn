using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Infrastructure;
using WeLearn.Services.Interfaces;

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

        public async Task<IActionResult> All()
        {
            var lessonsViewModels = await lessonsService.GetAllLessonsToVMAsync();
            return View(lessonsViewModels);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            var categories = await categoriesService.GetAllCategoriesAsync();
            ViewData["CategoryId"] = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(SharedConstants.MaximumVideoSizeInBytes)]
        public async Task<IActionResult> Create(LessonInputModel lessonInputModel)
        {
            if (!ModelState.IsValid)
            {
                var categories = await categoriesService.GetAllCategoriesAsync();
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
            var user = await userManager.GetUserAsync(HttpContext.User);
            var lesson = await lessonsService.GetLessonByIdAsync<LessonEditModel>(id);

            var categories = await categoriesService.GetAllCategoriesAsync();
            ViewData["CategoryId"] = new SelectList(categories, "Id", "Name", lesson.CategoryId);

            if (user.Id != lesson.UserId)
            {
                return View(nameof(Unauthorized));
            }

            return View(lesson);
        }

        [HttpPost]
        [Authorize]
        [RequestSizeLimit(SharedConstants.MaximumVideoSizeInBytes)]
        public async Task<IActionResult> Edit(LessonEditModel lessonEditModel)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);

            if (!ModelState.IsValid)
            {
                var categories = await categoriesService.GetAllCategoriesAsync();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", lessonEditModel.CategoryId);
                return View(lessonEditModel);
            }

            if (user.Id != lessonEditModel.UserId)
            {
                return View(nameof(Unauthorized));
            }

            await lessonsService.EditLessonAsync(lessonEditModel, environment.WebRootPath, environment.EnvironmentName, user.Id);
            return View("ThankYou");
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var lessonViewModel = await lessonsService.GetLessonByIdAsync<LessonViewModel>(id);

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
            var user = await userManager.GetUserAsync(HttpContext.User);
            var lesson = await lessonsService.GetLessonByIdAsync<Lesson>(lessonViewModel.LessonId);

            if (user.UserName != lesson.ApplicationUser.UserName)
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
            var myLessons = await lessonsService.UploadedByMeToVMAsync(userId);
            return View(myLessons);
        }

        public async Task<IActionResult> ByCategory(string categoryName)
        {
            var lessons = await lessonsService.GetAllRelevantLessonsToVMAsync(categoryName);
            return View(lessons);
        }

        public IActionResult Download([FromQuery] string link)
        {
            var fileParsed = fileDownloadService.DownloadFile(link);
            return File(fileParsed.Content, fileParsed.ContentType, fileParsed.FileName);
        }

        public async Task<IActionResult> Watch(int id)
        {
            var lessonViewModel = await lessonsService.GetLessonByIdAsync<LessonViewModel>(id);
            return View(lessonViewModel);
        }
    }
}

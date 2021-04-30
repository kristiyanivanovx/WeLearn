using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

using System.Security.Claims;
using System.Threading.Tasks;

using WeLearn.Data.Models;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Services.Interfaces;

namespace WeLearn.Controllers
{

    public class LessonController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<LessonController> logger;
        private readonly ICategoriesService categoriesService;
        private readonly IPostsService postsService;
        private readonly IFileDownloadService fileDownloadService;
        private readonly IWebHostEnvironment environment;
        private readonly IHttpContextAccessor httpContextAccessor;
        //private readonly IUserService userService;
        //private readonly UserManager<ApplicationUser> userManager;

        public LessonController(
            UserManager<ApplicationUser> userManager,
            ILogger<LessonController> logger,
            ICategoriesService categoriesService,
            IPostsService postsService,
            IFileDownloadService fileDownloadService,
            IWebHostEnvironment environment,
            IHttpContextAccessor httpContextAccessor) 
        {
            //this.userService = userService;
            this.userManager = userManager;
            this.logger = logger;
            this.categoriesService = categoriesService;
            this.postsService = postsService;
            this.fileDownloadService = fileDownloadService;
            this.environment = environment;
            this.httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> All()
        {
            var postsViewModels = await postsService.GetAllPostsAsync<PostViewModel>();
            return View(postsViewModels);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            var categories = await categoriesService.GetAllCategoriesAsync<Category>();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(PostInputModel postInputModel)
        {
            if (!ModelState.IsValid)
            {
                var categories = await categoriesService.GetAllCategoriesAsync<Category>();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", postInputModel.CategoryId);
                return View(postInputModel);
            }

            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await postsService.CreatePostAsync(postInputModel, environment.WebRootPath, userId);
            return View("ThankYou");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var post = await postsService.GetPostByIdAsync<PostEditModel>(id);

            var categories = await categoriesService.GetAllCategoriesAsync<Category>();
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", post.CategoryId);

            if (user.Id != post.UserId)
            {
                return View(nameof(Unauthorized));
            }

            return View(post);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(PostEditModel postEditModel)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            postEditModel.UserId = userId;

            if (!ModelState.IsValid)
            {
                var categories = await categoriesService.GetAllCategoriesAsync<Category>();
                ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName", postEditModel.CategoryId);
                return View(postEditModel);
            }

            if (user.Id != postEditModel.UserId)
            {
                return View(nameof(Unauthorized));
            }

            await postsService.EditPostAsync(postEditModel, environment.WebRootPath, userId);
            return View("ThankYou");
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var post = await postsService.GetPostByIdAsync<Post>(id);

            if (user.UserName != post.ApplicationUser.UserName)
            {
                return View("Unauthorized");
            }

            await postsService.DeletePostAsync(id);
            return View("Deleted");
        }

        [Authorize]
        public async Task<IActionResult> ByMe()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var myPosts = await postsService.UploadedByMeAsync<PostViewModel>(userId);
            return View(myPosts);
        }

        public async Task<IActionResult> ByCategory(string categoryName)
        {
            var posts = await postsService.GetAllPostsByCategoryNameAsync<PostViewModel>(categoryName);
            return View(posts);
        }

        public IActionResult Download([FromQuery] string link)
        {
            var fileParsed = fileDownloadService.DownloadFile(link);
            return File(fileParsed.Content, fileParsed.ContentType, fileParsed.FileName);
        }

        public async Task<IActionResult> Watch(int id)
        {
            var postViewModel = await postsService.GetPostByIdAsync<PostViewModel>(id);
            return View(postViewModel);
        }
    }
}

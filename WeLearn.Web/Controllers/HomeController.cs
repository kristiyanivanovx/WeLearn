using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Models;
using WeLearn.Services.Interfaces;

namespace WeLearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly ICategoriesService categoriesService;
        private readonly IUserService userService;
        private readonly IPostsService postsService;

        public HomeController(
            ILogger<HomeController> logger, 
            ICategoriesService categoriesService, 
            IUserService userService,
            IPostsService postsService)
        {
            this.logger = logger;
            this.categoriesService = categoriesService;
            this.userService = userService;
            this.postsService = postsService;
        }

        public async Task<IActionResult>  Index()
        {
            var indexViewModel = new IndexViewModel() 
            { 
                CategoriesCount = await categoriesService.GetAllCategoriesCountAsync(), 
                UsersCount = await userService.GetAllUsersCountAsync(), 
                PostsCount = await postsService.GetAllPostsCountAsync()
            };

            return View(indexViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

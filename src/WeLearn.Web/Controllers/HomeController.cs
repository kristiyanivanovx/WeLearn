using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;
using WeLearn.ViewModels.Home;

namespace WeLearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
            => this.homeService = homeService;

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = System.DateTimeOffset.Now.AddDays(30) }
            );

            return LocalRedirect(returnUrl);
        }

        public IActionResult Index()
        {
            IndexViewModel model = this.homeService.GenerateIndexViewModel();
            return View(model);
        }

        public IActionResult FAQ()
        {
            FrequentQuestionsViewModel model = this.homeService.GenerateFrequentQuestionsViewModel();
            return View(model);
        }

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

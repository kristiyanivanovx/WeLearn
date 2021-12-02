using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels;
using WeLearn.Web.ViewModels.Home;

namespace WeLearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
            => this.homeService = homeService;

        public IActionResult Index()
        {
            IndexViewModel model = this.homeService.GenerateIndexViewModel();
            return this.View(model);
        }

        public IActionResult FAQ()
        {
            FrequentQuestionsViewModel model = this.homeService.GenerateFrequentQuestionsViewModel();
            return this.View(model);
        }

        public IActionResult Privacy() => this.View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

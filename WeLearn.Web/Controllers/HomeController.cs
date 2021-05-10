using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using WeLearn.Models;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;

namespace WeLearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
            => this.homeService = homeService;

        public async Task<IActionResult> Index()
        {
            IndexViewModel indexViewModel = await homeService.GenerateIndexViewModelAsync();
            return View(indexViewModel);
        }

        public IActionResult FAQ() => View();

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

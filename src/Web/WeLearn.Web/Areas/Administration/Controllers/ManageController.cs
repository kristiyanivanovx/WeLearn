using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class ManageController : AdministrationController
    {
        private readonly IHomeService homeService;

        public ManageController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = this.homeService.GenerateIndexViewModel();
            return this.View(model);
        }
    }
}
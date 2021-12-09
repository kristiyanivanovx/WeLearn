using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class ManageController : AdministrationController
    {
        private readonly IInformationService informationService;

        public ManageController(IInformationService informationService)
        {
            this.informationService = informationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = this.informationService.GenerateAdministrationIndexViewModel();
            return this.View(model);
        }
    }
}

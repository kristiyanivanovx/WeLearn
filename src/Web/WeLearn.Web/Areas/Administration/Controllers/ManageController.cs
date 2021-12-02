using Microsoft.AspNetCore.Mvc;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class ManageController : AdministrationController
    {
        [HttpGet]
        public IActionResult Index() => this.View();
    }
}

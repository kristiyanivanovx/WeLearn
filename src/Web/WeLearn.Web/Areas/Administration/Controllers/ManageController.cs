using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Interfaces;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(ApplicationAdministrationAreaName)]
    [Authorize(Roles = ApplicationRegularAdministratorRoleName + "," + ApplicationTeacherRoleName)]
    public class ManageController : Controller
    {
        private readonly IInformationService informationService;

        public ManageController(IInformationService informationService)
        {
            this.informationService = informationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var model = await this.informationService.GenerateAdministrationIndexViewModel(userId);

            return this.View(model);
        }
    }
}

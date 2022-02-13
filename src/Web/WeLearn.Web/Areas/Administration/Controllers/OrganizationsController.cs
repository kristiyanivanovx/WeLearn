using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WeLearn.Services.Data;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Organization;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(SystemAdministrationAreaName)]
    [Authorize(Roles = SystemRegularAdministratorRoleName + "," + SystemTeacherRoleName)]
    public class OrganizationsController : Controller
    {
        private readonly IOrganizationsService organizationsService;

        public OrganizationsController(IOrganizationsService organizationsService)
        {
            this.organizationsService = organizationsService;
        }

        public IActionResult Index()
        {
            var models = this.organizationsService
                .GetAllAsync<OrganizationViewModel>(true);

            return this.View(models);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = this.organizationsService.GetById<OrganizationEditModel>(id, true);

            return this.View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(OrganizationEditModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.organizationsService.EditAsync(model, true);

            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpPost]
        [Authorize(Roles = SystemRegularAdministratorRoleName)]
        public async Task<RedirectToActionResult> Delete(int id)
        {
            await this.organizationsService.HardDeleteAsync(id, true);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

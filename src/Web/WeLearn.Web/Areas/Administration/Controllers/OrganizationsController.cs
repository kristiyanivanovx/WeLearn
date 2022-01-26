using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WeLearn.Services;
using WeLearn.Services.Data;
using WeLearn.Web.ViewModels.Organization;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(ApplicationAdministrationAreaName)]
    [Authorize(Roles = ApplicationRegularAdministratorRoleName + "," + ApplicationTeacherRoleName)]
    public class OrganizationsController : Controller
    {
        private readonly OrganizationsService organizationsService;

        public OrganizationsController(OrganizationsService organizationsService)
        {
            this.organizationsService = organizationsService;
        }

        public IActionResult Index()
        {
            var models = this.organizationsService
                .GetAllToModelAsync<OrganizationViewModel>(true);

            return this.View(models);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = this.organizationsService.GetByIdToModelAsync<OrganizationEditModel>(id, true);

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
        [Authorize(Roles = ApplicationRegularAdministratorRoleName)]
        public async Task<RedirectToActionResult> Delete(int id)
        {
            await this.organizationsService.HardDeleteAsync(id, true);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

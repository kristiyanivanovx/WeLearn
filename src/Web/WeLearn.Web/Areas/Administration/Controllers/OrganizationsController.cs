using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Organization;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class OrganizationsController : AdministrationController
    {
        private readonly OrganizationsService organizationsService;
        private readonly IUsersService usersService;

        public OrganizationsController(
            OrganizationsService organizationsService,
            IUsersService usersService)
        {
            this.organizationsService = organizationsService;
            this.usersService = usersService;
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

            await this.organizationsService.EditOrganizationAsync(model, true);

            return this.RedirectToAction(nameof(this.Index));
        }

        public async Task<RedirectToActionResult> Delete(int id)
        {
            await this.organizationsService.HardDeleteAsync(id, true);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

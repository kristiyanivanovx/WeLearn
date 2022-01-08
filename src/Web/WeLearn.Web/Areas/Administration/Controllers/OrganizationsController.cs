using System.Threading.Tasks;
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
                .GetAllToModelAsync<OrganizationViewModel>();

            return this.View(models);
        }

        public async Task<RedirectToActionResult> Delete(int id)
        {
            await this.organizationsService.HardDeleteAsync(id);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

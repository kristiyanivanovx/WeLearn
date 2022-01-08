using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Organization;

namespace WeLearn.Web.Controllers
{
    public class OrganizationController : BaseController
    {
        private readonly IUsersService usersService;
        private readonly OrganizationsService organizationsService;

        // todo: service
        public OrganizationController(
            IUsersService usersService,
            OrganizationsService organizationsService)
        {
            this.usersService = usersService;
            this.organizationsService = organizationsService;
        }

        [Authorize]
        public IActionResult Joined()
        {
            var models = this.organizationsService
                .GetByMemberIdToModel<OrganizationViewModel>(this.GetUserId());

            return this.View(models);
        }

        [Authorize]
        public async Task<IActionResult> Join(int id)
        {
            await this.organizationsService.AddUserToOrganization(id, this.GetUserId());

            return this.RedirectToAction(nameof(this.All));
        }

        [Authorize]
        public async Task<IActionResult> Leave(int id)
        {
            await this.organizationsService.RemoveUserFromOrganization(id, this.GetUserId());

            return this.RedirectToAction(nameof(this.All));
        }

        public IActionResult View(int id)
        {
            var models = this.organizationsService.GetByIdToModelAsync<OrganizationViewModel>(id);

            return this.View(models);
        }

        public IActionResult All()
        {
            var models = this.organizationsService.GetAllToModelAsync<OrganizationViewModel>();

            return this.View(models);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(OrganizationInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.organizationsService.CreateAsync(model, this.GetUserId());

            return this.RedirectToAction(nameof(this.All));
        }
    }
}

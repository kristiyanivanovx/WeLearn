using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services;
using WeLearn.Web.ViewModels.Organization;

namespace WeLearn.Web.Controllers
{
    public class OrganizationController : BaseController
    {
        private readonly OrganizationsService organizationsService;

        public OrganizationController(OrganizationsService organizationsService)
        {
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
            var model = this.organizationsService.GetByIdToModelAsync<OrganizationViewModel>(id);
            if (model == null)
            {
                this.Response.StatusCode = 404;
                return this.NotFound();
            }

            return this.View(model);
        }

        public IActionResult All()
        {
            var models = this.organizationsService
                .GetAllToModelAsync<OrganizationViewModel>();

            return this.View(models);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = this.organizationsService.GetByIdToModelAsync<OrganizationEditModel>(id);

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

            if (model.CreatorId.Equals(this.GetUserId()))
            {
                await this.organizationsService.EditOrganizationAsync(model);
            }

            return this.RedirectToAction(nameof(this.View), new { id = model.Id });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var model = this.organizationsService.GetById(id);
            if (model.CreatorId.Equals(this.GetUserId()))
            {
                await this.organizationsService.DeleteOrganizationAsync(model);
            }

            return this.RedirectToAction(nameof(this.All));
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
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WeLearn.Services.Data;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Organization;

namespace WeLearn.Web.Controllers
{
    public class OrganizationController : BaseController
    {
        private readonly IOrganizationsService organizationsService;

        public OrganizationController(IOrganizationsService organizationsService)
            => this.organizationsService = organizationsService;

        [Authorize]
        public IActionResult Joined()
        {
            var models = this.organizationsService
                .GetByMemberId<OrganizationViewModel>(this.GetUserId());

            return this.View(models);
        }

        [Authorize]
        public IActionResult ByMe()
        {
            var models = this.organizationsService
                .GetByCreatorId<OrganizationViewModel>(this.GetUserId());

            return this.View(models);
        }

        [Authorize]
        public async Task<IActionResult> Join(int id)
        {
            await this.organizationsService.AddUserAsync(id, this.GetUserId());

            return this.RedirectToAction(nameof(this.All));
        }

        [Authorize]
        public async Task<IActionResult> Leave(int id)
        {
            await this.organizationsService.RemoveUserAsync(id, this.GetUserId());

            return this.RedirectToAction(nameof(this.All));
        }

        public IActionResult View(int id)
        {
            var model = this.organizationsService.GetById<OrganizationViewModel>(id);
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
                .GetAllAsync<OrganizationViewModel>();

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
            var model = this.organizationsService.GetById<OrganizationEditModel>(id);

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
                await this.organizationsService.EditAsync(model);
            }

            return this.RedirectToAction(nameof(this.View), new { id = model.Id });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = this.GetUserId();
            await this.organizationsService.SoftDeleteAsync(id, userId);

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

            var organizationId = await this.organizationsService.CreateAsync(model, this.GetUserId());

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            await this.organizationsService.AddUserAsync(organizationId, userId);

            return this.RedirectToAction(nameof(this.All));
        }
    }
}

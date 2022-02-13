using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Admin.User;
using WeLearn.Web.ViewModels.HelperModels;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area(SystemAdministrationAreaName)]
    [Authorize(Roles = SystemRegularAdministratorRoleName + "," + SystemTeacherRoleName)]
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            var allUsers = await this.usersService.GetAllUsersAsync<AdminUserViewModel>(searchString);
            var paginated = PaginatedList<AdminUserViewModel>.Create(allUsers.OrderBy(x => x.Id), pageNumber ?? 1, 6);
            paginated.SearchString = searchString;

            return this.View(paginated);
        }

        [HttpPost]
        [Authorize(Roles = SystemHeadAdministratorRoleName)]
        public async Task<IActionResult> ToggleAdminRole(string userId)
        {
            await this.usersService.ToggleAdminRoleAsync(userId);

            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpPost]
        [Authorize(Roles = SystemRegularAdministratorRoleName)]
        public async Task<IActionResult> ToggleTeacherRole(string userId)
        {
            var actingUserId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            await this.usersService.ToggleTeacherRoleAsync(userId, actingUserId);

            return this.RedirectToAction(nameof(this.Index));
        }

        [Authorize(Roles = SystemHeadAdministratorRoleName)]
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await this.usersService.GetUserByIdAsync<AdminUserDeleteModel>(id);

            return this.View(user);
        }

        [Authorize(Roles = SystemHeadAdministratorRoleName)]
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await this.usersService.HardDeleteUserByIdAsync(id);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}

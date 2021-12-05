using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.Web.ViewModels.Admin.User;
using WeLearn.Web.ViewModels.HelperModels;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    public class UsersController : AdministrationController
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

            return View(paginated);
        }

        [HttpPost]
        [Authorize(Roles = ApplicationHeadAdministratorRoleName)]
        public async Task<IActionResult> ToggleAdminRole(string userId)
        {
            await this.usersService.ToggleAdminRoleAsync(userId);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = ApplicationHeadAdministratorRoleName)]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await this.usersService.GetUserByIdAsync<AdminUserDeleteModel>(id);

            return View(user);
        }

        [HttpPost]
        [ActionName("Delete")]
        [Authorize(Roles = ApplicationHeadAdministratorRoleName)]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await this.usersService.HardDeleteUserByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

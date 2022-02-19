using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeLearn.Data.Models.Identity;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.ApplicationUser;

namespace WeLearn.Web.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUsersService usersService;
        private readonly IInputOutputService inputOutputService;

        public ProfileController(
            UserManager<ApplicationUser> userManager,
            IUsersService usersService,
            IInputOutputService inputOutputService)
        {
            this.userManager = userManager;
            this.usersService = usersService;
            this.inputOutputService = inputOutputService;
        }

        // [Authorize]
        // public IActionResult UploadProfileImage(string id)
        // {
        //     var model = new ProfileViewModel()
        //     {
        //
        //     };
        //
        //     // return this.RedirectToAction(nameof(this.Details(id)));
        // }

        public async Task<IActionResult> Details(string id)
        {
            var user = await this.usersService.GetByIdAsync<ProfileViewModel>(id);

            return this.View();
        }
    }
}


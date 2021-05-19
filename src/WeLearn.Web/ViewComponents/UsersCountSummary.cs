using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeLearn.Services.Interfaces;

namespace WeLearn.Web.ViewComponents
{
    public class UsersCountSummary : ViewComponent
    {
        private readonly IViewComponentsService viewComponentsService;

        public UsersCountSummary(IViewComponentsService viewComponentsService)
            => this.viewComponentsService = viewComponentsService;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int userCount = await viewComponentsService.GetUsersCount();
            return View(userCount);
        }
    }
}

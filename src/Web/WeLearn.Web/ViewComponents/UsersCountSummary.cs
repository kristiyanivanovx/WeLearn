using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
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
            int userCount = await this.viewComponentsService.GetUsersCount();
            return this.View(userCount);
        }
    }
}

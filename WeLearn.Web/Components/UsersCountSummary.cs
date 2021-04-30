using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WeLearn.Data.Context;

namespace WeLearn.Web.Components
{
    public class UsersCountSummary : ViewComponent
    {
        private readonly ApplicationDbContext context;

        public UsersCountSummary(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            var userCount = context.Users.Count();
            return View(userCount);
        }
    }
}

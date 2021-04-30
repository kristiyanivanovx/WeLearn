using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WeLearn.Data.Context;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Web.Components
{
    public class PostsNavigatorDropdown : ViewComponent
    {
        private readonly ApplicationDbContext context;

        public PostsNavigatorDropdown(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            var postsNavigationDropdownModel = new PostsNavigationDropdownModel
            {
                Categories = context.Categories,
                Posts = context.Posts
            };

            return View(postsNavigationDropdownModel);
        }
    }
}

using System.Collections.Generic;
using WeLearn.Data.Models;

namespace WeLearn.Infrastructure.ViewModels
{
    public class PostsNavigationDropdownModel
    {
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}

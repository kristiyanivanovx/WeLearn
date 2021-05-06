using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Services.Interfaces;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Data;

namespace WeLearn.Services
{
    public class HomeService : IHomeService
    {
        private readonly ICategoriesService categoriesService;
        private readonly IUsersService userService;
        private readonly ILessonsService lessonsService;

        public HomeService(
            ICategoriesService categoriesService,
            IUsersService userService,
            ILessonsService lessonsService)
        {
            this.categoriesService = categoriesService;
            this.userService = userService;
            this.lessonsService = lessonsService;
        }

        public async Task<IndexViewModel> GenerateIndexViewModelAsync()
            => new IndexViewModel()
                {
                    CategoriesCount = await categoriesService.GetAllCategoriesCountAsync(),
                    UsersCount = await userService.GetAllUsersCountAsync(),
                    LessonsCount = await lessonsService.GetAllLessonsCountAsync()
                };
    }
}

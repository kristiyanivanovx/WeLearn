using System.Threading.Tasks;
using WeLearn.Services.Interfaces;
using WeLearn.ViewModels;

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

        public IndexViewModel GenerateIndexViewModel()
            => new IndexViewModel()
                {
                    CategoriesCount = this.categoriesService.GetAllCategoriesCount(),
                    UsersCount = this.userService.GetAllUsersCount(),
                    LessonsCount = this.lessonsService.GetAllLessonsCount()
                };
    }
}

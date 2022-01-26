using System.Threading.Tasks;

using WeLearn.Services.Data.Interfaces;
using WeLearn.Web.ViewModels.Admin;
using WeLearn.Web.ViewModels.Home;

using static WeLearn.Data.Common.Validation.DataValidation.Material;
using static WeLearn.Data.Common.Validation.DataValidation.Video;

namespace WeLearn.Services.Data
{
    public class InformationService : IInformationService
    {
        private readonly ICategoriesService categoriesService;
        private readonly QuizzesService quizzesService;
        private readonly IReportsService reportsService;
        private readonly IUsersService userService;
        private readonly ILessonsService lessonsService;

        public InformationService(
            ICategoriesService categoriesService,
            QuizzesService quizzesService,
            IReportsService reportsService,
            IUsersService userService,
            ILessonsService lessonsService)
        {
            this.categoriesService = categoriesService;
            this.quizzesService = quizzesService;
            this.reportsService = reportsService;
            this.userService = userService;
            this.lessonsService = lessonsService;
        }

        public FrequentQuestionsViewModel GenerateFrequentQuestionsViewModel()
            => new FrequentQuestionsViewModel
                {
                    AllowedFileExtensions = string.Join(", ", AllowedFileExtensions),
                    AllowedVideoExtensions = string.Join(", ", AllowedVideoExtensions),
                };

        public IndexViewModel GenerateIndexViewModel()
            => new IndexViewModel
                {
                    CategoriesCount = this.categoriesService.GetCount(),
                    UsersCount = this.userService.GetCount(),
                    LessonsCount = this.lessonsService.GetCount(),
                };

        public async Task<AdministrationIndexViewModel> GenerateAdministrationIndexViewModel(string userId)
            => new AdministrationIndexViewModel
                {
                    CategoriesCount = this.categoriesService.GetCount(),
                    UsersCount = this.userService.GetCount(),
                    LessonsCount = this.lessonsService.GetCount(),
                    ReportsCount = this.reportsService.GetCount(),
                    QuizzesCount = this.quizzesService.GetCount(),
                    RoleNames = await this.userService.GetRoleNamesByUserId(userId),
                };
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface IViewComponentsService
    {
        Task<int> GetUsersCountAsync();

        LessonsNavigationDropdownModel GenerateDropdownModel();

        Task<IEnumerable<CommentViewModel>> GenerateCommentViewModelsAsync(int lessonId);
    }
}

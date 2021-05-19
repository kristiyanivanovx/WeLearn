using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface IViewComponentsService
    {
        Task<int> GetUsersCount();

        LessonsNavigationDropdownModel GenerateDropdownModel();

        Task<IEnumerable<CommentViewModel>> GetCommentsAsync(int lessonId);
    }
}

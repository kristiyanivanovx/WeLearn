using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.ViewModels;
using WeLearn.ViewModels.Comment;
using WeLearn.ViewModels.Lesson;

namespace WeLearn.Services.Interfaces
{
    public interface IViewComponentsService
    {
        Task<int> GetUsersCount();

        LessonsNavigationDropdownModel GenerateDropdownModel();

        Task<IEnumerable<CommentViewModel>> GetCommentsAsync(int lessonId);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Web.ViewModels.Comment;
using WeLearn.Web.ViewModels.Lesson;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IViewComponentsService
    {
        Task<int> GetUsersCount();

        LessonsNavigationDropdownModel GenerateDropdownModel();

        Task<IEnumerable<CommentViewModel>> GetCommentsAsync(int lessonId);
    }
}

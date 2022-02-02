using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Web.ViewModels.Admin.Comment;
using WeLearn.Web.ViewModels.Comment;

namespace WeLearn.Services.Data.Interfaces
{
    public interface ICommentsService
    {
        bool Contains(int id);

        bool IsInLessonId(int commentId, int lessonId);

        Task<T> GetCommentByIdWithDeletedAsync<T>(int id);

        Task<IEnumerable<AdminCommentViewModel>> GetAllCommentsAsync(string searchString);

        Task<IEnumerable<CommentByMeModel>> GetCommentsMadeByMeAsync(string userId);

        Task CreateCommentAsync(CommentInputModel commentViewModel, int? parentId);

        Task EditCommentAsync(CommentEditModel commentEditModel);

        Task EditCommentByAdminAsync(AdminCommentEditModel commentEditModel);

        Task SoftDeleteCommentByIdAsync(int commentId);

        Task HardDeleteCommentByIdAsync(int commentId);
    }
}

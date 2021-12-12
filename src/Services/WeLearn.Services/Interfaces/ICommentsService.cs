using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Web.ViewModels.Admin.Comment;
using WeLearn.Web.ViewModels.Comment;

namespace WeLearn.Services.Interfaces
{
    public interface ICommentsService
    {
        bool Contains(int id);

        Task<T> GetCommentByIdWithDeletedAsync<T>(int id);

        Task<IEnumerable<AdminCommentViewModel>> GetAllCommentsAsync(string searchString);

        Task<IEnumerable<CommentByMeModel>> GetCommentsMadeByMeAsync(string userId);

        Task CreateCommentAsync(CommentInputModel commentViewModel);

        Task EditCommentAsync(CommentEditModel commentEditModel);

        Task EditCommentByAdminAsync(AdminCommentEditModel commentEditModel);

        Task SoftDeleteCommentByIdAsync(int commentId);

        Task HardDeleteCommentByIdAsync(int commentId);
    }
}

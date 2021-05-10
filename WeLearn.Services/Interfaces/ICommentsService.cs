using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface ICommentsService
    {
        Task<T> GetCommentByIdAsync<T>(int id);

        Task<IEnumerable<CommentAdministrationModel>> GetAllComments(string searchString);

        Task<IEnumerable<CommentMultiModel>> GetCommentsMadeByMeAsync(string userId);

        Task CreateCommentAsync(CommentViewModel commentViewModel);

        Task EditCommentAsync(CommentMultiModel commentEditModel);

        Task EditCommentByAdminAsync(CommentAdministrationModel commentEditModel);

        Task SoftDeleteCommentByIdAsync(int commentId);

        Task HardDeleteCommentByIdAsync(int commentId);
    }
}

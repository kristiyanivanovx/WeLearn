using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.ViewModels;
using WeLearn.Data.Models;

namespace WeLearn.Services.Interfaces
{
    public interface ICommentsService
    {
        Task<T> GetCommentByIdAsync<T>(int id);

        Task CreateCommentAsync(CommentViewModel commentViewModel);

        Task EditCommentAsync(CommentMultiModel commentEditModel);
        
        Task DeleteCommentAsync(Comment comment);
        
        Task<IEnumerable<CommentMultiModel>> CommentsMadeByMeAsync(string userId);
    }
}

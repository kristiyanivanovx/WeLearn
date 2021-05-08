using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Data.Models;

namespace WeLearn.Services.Interfaces
{
    public interface ICommentsService
    {
        Task EditCommentAsync(CommentMultiModel commentEditModel);
        
        Task DeleteCommentAsync(Comment comment);
        
        Task<IEnumerable<CommentMultiModel>> MadeByMeToCommentMultiModelAsync(string userId);

        Task CreateCommentAsync(CommentViewModel commentViewModel);
        
        Task<T> GetCommentByIdAsync<T>(int id);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface ICommentsService
    {
        Task EditCommentAsync(CommentMultiModel commentEditModel);
        
        Task DeleteCommentByIdAsync(int id);
        
        Task<IEnumerable<CommentMultiModel>> MadeByMeToCommentMultiModelAsync(string userId);

        Task CreateCommentAsync(CommentViewModel commentViewModel);
        
        Task<T> GetCommentByIdAsync<T>(int id);
    }
}

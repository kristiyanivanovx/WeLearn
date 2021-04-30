using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface ICommentsService
    {
        Task<T> GetCommentByIdAsync<T>(int id);
        
        Task EditCommentAsync(CommentMultiModel commentEditModel);
        
        Task DeleteCommentByIdAsync(int id);
        
        Task<IEnumerable<T>> UploadedByMeAsync<T>(string userId);
    }
}

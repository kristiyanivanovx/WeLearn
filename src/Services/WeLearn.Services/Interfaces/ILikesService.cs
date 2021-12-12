using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models;

namespace WeLearn.Services.Interfaces
{
    public interface ILikesService
    {
        Task<IEnumerable<T>> GetByUserId<T>(string userId);

        Task ToggleLikeAsync(int lessonId, string userId);

        Task AddLikeAsync(int lessonId, string userId);

        void RemoveLike(Like like);

        int GetLikesCount(int lessonId);
    }
}

using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

namespace WeLearn.Services.Interfaces
{
    public interface ILikesService
    {
        Task ToggleLikeAsync(int lessonId, string userId);

        Task AddLikeAsync(int lessonId, string userId);

        void RemoveLike(Like like);

        int GetLikesCount(int lessonId);
    }
}

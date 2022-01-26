using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

namespace WeLearn.Services.Data.Interfaces
{
    public interface ILikesService
    {
        Task ToggleLikeAsync(int lessonId, string userId);

        Task AddLikeAsync(int lessonId, string userId);

        void RemoveLikeAsync(Like like);

        int GetLikesCount(int lessonId);
    }
}

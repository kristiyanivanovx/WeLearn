using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

namespace WeLearn.Services.Data.Interfaces
{
    public interface ILikesService
    {
        Task ToggleAsync(int lessonId, string userId);

        Task AddAsync(int lessonId, string userId);

        Task RemoveAsync(Like like);

        int GetCountByLessonId(int lessonId);
    }
}

using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Services.Data.Interfaces;

namespace WeLearn.Services.Data
{
    public class LikesService : ILikesService
    {
        private readonly IDeletableEntityRepository<Like> likesRepository;

        public LikesService(IDeletableEntityRepository<Like> likesRepository)
            => this.likesRepository = likesRepository;

        public int GetCountByLessonId(int lessonId)
            => this.likesRepository
                .All()
                .Count(x => x.LessonId == lessonId);

        public async Task ToggleAsync(int lessonId, string userId)
        {
            var like = this.likesRepository
                .All()
                .FirstOrDefault(x => x.LessonId == lessonId && x.UserId == userId);

            if (like == null)
            {
                await this.AddAsync(lessonId, userId);
            }
            else
            {
                await this.RemoveAsync(like);
            }
        }

        public async Task AddAsync(int lessonId, string userId)
        {
            var like = new Like
            {
                LessonId = lessonId,
                UserId = userId,
            };

            await this.likesRepository.AddAsync(like);
            await this.likesRepository.SaveChangesAsync();
        }

        public async Task RemoveAsync(Like like)
        {
            this.likesRepository.HardDelete(like);
            await this.likesRepository.SaveChangesAsync();
        }
    }
}

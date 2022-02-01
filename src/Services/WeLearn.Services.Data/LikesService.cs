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

        public int GetLikesCount(int lessonId)
            => this.likesRepository
                .All()
                .Count(x => x.LessonId == lessonId);

        public async Task ToggleLikeAsync(int lessonId, string userId)
        {
            var dbLike = this.likesRepository
                .All()
                .FirstOrDefault(x => x.LessonId == lessonId && x.UserId == userId);

            // if the like doesn't already exist - user puts a like for the first time
            // else, the like exists and the user wants to remove it
            if (dbLike == null)
            {
                await this.AddLikeAsync(lessonId, userId);
            }
            else
            {
                this.RemoveLikeAsync(dbLike);
            }
        }

        public async Task AddLikeAsync(int lessonId, string userId)
        {
            var like = new Like
            {
                LessonId = lessonId,
                UserId = userId,
            };

            await this.likesRepository.AddAsync(like);
            await this.likesRepository.SaveChangesAsync();
        }

        public async void RemoveLikeAsync(Like like)
        {
            this.likesRepository.HardDelete(like);
            await this.likesRepository.SaveChangesAsync();
        }
    }
}

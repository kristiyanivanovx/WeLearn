using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Hangfire;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Models.Recommendation;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Services.CronJobs
{
    public class GetPersonalRecommendationsJob
    {
        private readonly IDeletableEntityRepository<Like> likesRepository;
        private readonly RecommendationsService recommendationsService;

        public GetPersonalRecommendationsJob(
            IDeletableEntityRepository<Like> likesRepository,
            RecommendationsService recommendationsService)
        {
            this.likesRepository = likesRepository;
            this.recommendationsService = recommendationsService;
        }

        [AutomaticRetry(Attempts = 2)]
        public async Task WorkAsync(string path)
        {
            var latestLikesModels = await this.likesRepository
                .All()
                .Select(x => new LikeLessonUserModel
                {
                    UserId = x.ApplicationUserId,
                    LessonId = x.LessonId,
                })
                .ToListAsync();

            // generate all possible combinations and only store these that pass a certain threshold
            IEnumerable<string> userIds = latestLikesModels.Select(x => x.UserId);
            IEnumerable<int> lessonIds = latestLikesModels.Select(x => x.LessonId);

            // todo: think about shortening out
            IEnumerable<UserInLesson> allCombinations = userIds
                .SelectMany(userId => lessonIds
                    .Where(lessonId => !latestLikesModels
                        .Exists(model => model.UserId.Equals(userId) && model.LessonId == lessonId))
                    .Select(lessonId => new UserInLesson { UserId = userId, LessonId = lessonId }))
                .GroupBy(x => new { x.UserId, x.LessonId })
                .Select(g => g.First())
                .ToList();

            // Console.WriteLine(allCombinations.Count());
            string modelFilePath = Path.Combine(path, ExportDirectory, ModelFile);

            // using existing model, check for all possible combinations and store them to database
            await this.recommendationsService.TestRecommendationsModel(modelFilePath, allCombinations);
        }
    }
}

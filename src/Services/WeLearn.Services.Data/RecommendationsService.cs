using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.ML;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Models.Recommendation;

namespace WeLearn.Services.Data
{
    public class RecommendationsService
    {
        private readonly IDeletableEntityRepository<Recommendation> recommendationsRepository;

        public RecommendationsService(IDeletableEntityRepository<Recommendation> recommendationsRepository)
            => this.recommendationsRepository = recommendationsRepository;

        public async Task TestRecommendationsModel(string modelFile, IEnumerable<UserInLesson> testModelData)
        {
            var context = new MLContext();
            var model = context.Model.Load(modelFile, out _);
            var predictionEngine = context.Model.CreatePredictionEngine<UserInLesson, UserInLessonScore>(model);

            foreach (var testInput in testModelData)
            {
                var prediction = predictionEngine.Predict(testInput);

                // Console.WriteLine($"User: {testInput.UserId}, Lesson: {testInput.LessonId}, Score: {prediction.Score}");
                var recommendation = new Recommendation
                {
                    UserId = testInput.UserId,
                    LessonId = testInput.LessonId,
                    Score = prediction.Score,
                };

                var existingRecommendation = this.recommendationsRepository
                    .All()
                    .FirstOrDefault(x =>
                        x.UserId.Equals(recommendation.UserId) && x.LessonId == recommendation.LessonId);

                if (existingRecommendation != null)
                {
                    this.recommendationsRepository.HardDelete(existingRecommendation);
                    await this.recommendationsRepository.SaveChangesAsync();
                }

                await this.recommendationsRepository.AddAsync(recommendation);
            }

            await this.recommendationsRepository.SaveChangesAsync();
        }
    }
}

using Hangfire;

using static WeLearn.Services.ML.RecommendationsService;
using static WeLearn.Common.GlobalConstants;
using System.IO;

namespace WeLearn.Services.CronJobs
{
    public class TrainRecommendationModelJob
    {
        [AutomaticRetry(Attempts = 2)]
        public void Work(string path)
        {
            var trainedRecommendationsModelFile = System.IO.Path.Combine(path, "data", ModelFile);
            var dataModel = System.IO.Path.Combine(path, "data", "UsersInLessons.csv");

            TrainModel(dataModel, trainedRecommendationsModelFile);
        }
    }
}

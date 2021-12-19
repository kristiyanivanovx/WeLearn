using System.IO;

using Hangfire;

using static WeLearn.Common.GlobalConstants;
using static WeLearn.Services.ML.RecommendationsService;

namespace WeLearn.Services.CronJobs
{
    public class TrainRecommendationModelJob
    {
        [AutomaticRetry(Attempts = 2)]
        public void Work(string path)
        {
            string trainedRecommendationsModelFile = Path.Combine(path, ExportDirectory, ModelFile);
            string dataModel = Path.Combine(path, ExportDirectory, ExportFileName);

            TrainModel(dataModel, trainedRecommendationsModelFile);
        }
    }
}

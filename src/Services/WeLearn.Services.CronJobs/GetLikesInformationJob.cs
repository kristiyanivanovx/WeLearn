using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using CsvHelper;
using Hangfire;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Models.Recommendation;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Services.CronJobs
{
    public class GetLikesInformationJob
    {
        private readonly IDeletableEntityRepository<Like> likesRepository;

        public GetLikesInformationJob(IDeletableEntityRepository<Like> likesRepository)
        {
            this.likesRepository = likesRepository;
        }

        [AutomaticRetry(Attempts = 2)]
        public async Task Work(string path)
        {
            var latestLikes = await this.likesRepository
                .All()
                .Select(x => new LikeLessonUserModel
                {
                    UserId = x.UserId,
                    LessonId = x.LessonId,
                })
                .ToListAsync();

            string modelPath = Path.Combine(path, ExportDirectory, ExportFileName);

            await using var writer = new StreamWriter(modelPath);
            await using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            await csv.WriteRecordsAsync(latestLikes);
        }
    }
}

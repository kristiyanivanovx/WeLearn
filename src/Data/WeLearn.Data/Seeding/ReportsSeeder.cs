using System;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class ReportsSeeder : ISeeder
    {
        public async Task SeedAsync(DatabaseContext databaseContext, IServiceProvider serviceProvider)
        {
            var reportsCount = databaseContext.Reports.ToList().Count;
            if (reportsCount == 0)
            {
                await databaseContext.Reports.AddRangeAsync(
                        new Report
                        {
                            Id = 1,
                            UserId = SystemHeadAdministratorId,
                            LessonId = 5,
                            Subject = "The language used in title",
                            Description = "Bad language in lesson's title.",
                        },
                        new Report
                        {
                            Id = 3,
                            UserId = SystemHeadAdministratorId,
                            CommentId = 1,
                            Subject = "Unacceptable behaviour",
                            Description = "Bad language in comment.",
                        });
            }
        }
    }
}

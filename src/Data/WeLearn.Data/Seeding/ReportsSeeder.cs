using System;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Common;
using WeLearn.Data.Models;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class ReportsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var reportsCount = dbContext.Reports.ToList().Count;
            if (reportsCount == 0)
            {
                await dbContext.Reports.AddRangeAsync(
                        new Report
                        {
                            Id = 1, ApplicationUserId = SeededUserId, LessonId = 5,
                            Subject = "The language used in title", Description = "Bad language in lesson's title."
                        },
                        new Report
                        {
                            Id = 3, ApplicationUserId = SeededUserId, CommentId = 1,
                            Subject = "Unacceptable behaviour", Description = "Bad language in comment."
                        });
            }
        }
    }
}

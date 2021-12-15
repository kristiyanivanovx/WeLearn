using System;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class CommentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var commentsCount = dbContext.Comments.Count();
            if (commentsCount == 0)
            {
                await dbContext.Comments.AddRangeAsync(
                    new Comment
                    {
                        Id = 1,
                        ApplicationUserId = ApplicationAdministratorId,
                        Content = "I like it!",
                        LessonId = 1
                    },
                    new Comment
                    {
                        Id = 2,
                        ApplicationUserId = ApplicationAdministratorId,
                        Content = "The teacher is awesome.",
                        LessonId = 2
                    },
                    new Comment
                    {
                        Id = 3,
                        ApplicationUserId = ApplicationAdministratorId,
                        Content = "This is just great.",
                        LessonId = 3
                    });
            }
        }
    }
}

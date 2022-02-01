using System;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class CommentsSeeder : ISeeder
    {
        public async Task SeedAsync(DatabaseContext databaseContext, IServiceProvider serviceProvider)
        {
            var commentsCount = databaseContext.Comments.Count();
            if (commentsCount == 0)
            {
                await databaseContext.Comments.AddRangeAsync(
                    new Comment
                    {
                        Id = 1,
                        UserId = SystemHeadAdministratorId,
                        Content = "I like it!",
                        LessonId = 1
                    },
                    new Comment
                    {
                        Id = 2,
                        UserId = SystemHeadAdministratorId,
                        Content = "The teacher is awesome.",
                        LessonId = 2
                    },
                    new Comment
                    {
                        Id = 3,
                        UserId = SystemHeadAdministratorId,
                        Content = "This is just great.",
                        LessonId = 3
                    });
            }
        }
    }
}

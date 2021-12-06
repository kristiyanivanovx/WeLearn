using System;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Common;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Enums;

namespace WeLearn.Data.Seeding
{
    public class LessonsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var lessonsCount = dbContext.Lessons.Count();
            if (lessonsCount == 0)
            {
                await dbContext.Lessons.AddRangeAsync(
                    new Lesson
                    {
                        Id = 1, VideoId = 1, MaterialId = 1, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 1, Grade = Grade.First, Name = "Pronouns, types",
                        Description = "A lecture about pronouns and when to use them."
                    },
                    new Lesson
                    {
                        Id = 2, VideoId = 2, MaterialId = 2, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 2, Grade = Grade.Second, CreatedOn = DateTime.UtcNow, Name = "Prime numbers",
                        Description =
                            "A natural number greater than 1 that is not a product of two smaller natural numbers."
                    },
                    new Lesson
                    {
                        Id = 3, VideoId = 3, MaterialId = 3, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 3, Grade = Grade.Third, Name = "Developing with C#",
                        Description = "About the C# language and the .NET development Platform. First steps."
                    },
                    new Lesson
                    {
                        Id = 4, VideoId = 4, MaterialId = 4, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 4, Grade = Grade.Fourth, CreatedOn = DateTime.UtcNow, Name = "Excel",
                        Description = "Data analysis."
                    },
                    new Lesson
                    {
                        Id = 5, VideoId = 5, MaterialId = 5, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 5, Grade = Grade.Fifth,
                        Name = "Ukraine, Eastern Europe",
                        Description =
                            "Eastern European Countries. Their economic growth and political stances. Ukraine."
                    },
                    new Lesson
                    {
                        Id = 6, VideoId = 6, MaterialId = 6, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 6, Grade = Grade.Sixth, Name = "Football",
                        Description = "Kicking a ball on the field."
                    },
                    new Lesson
                    {
                        Id = 7, VideoId = 7, MaterialId = 7, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 7, Grade = Grade.Seventh,
                        Name = "William Shakespeare's 106 sonnet", Description = "A peek into Shakespeare's art."
                    },
                    new Lesson
                    {
                        Id = 8, VideoId = 8, MaterialId = 8, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 8, Grade = Grade.Eighth, Name = "Human rights",
                        Description = "A lecture about rights of the people."
                    },
                    new Lesson
                    {
                        Id = 9, VideoId = 9, MaterialId = 9, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 9, Grade = Grade.Ninth, Name = "Modal verbs",
                        Description =
                            "We use modals to show if we believe something is certain, possible or impossible."
                    },
                    new Lesson
                    {
                        Id = 10, VideoId = 10, MaterialId = 10, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 10, Grade = Grade.Tenth, Name = "Verbs of motion",
                        Description = "A lecture about the verbs of motion and when to use them."
                    },
                    new Lesson
                    {
                        Id = 11, VideoId = 11, MaterialId = 11, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 11, Grade = Grade.Eleventh, Name = "Peek in the past",
                        Description = "A brief peek into our ancestors' life."
                    },
                    new Lesson
                    {
                        Id = 12, VideoId = 12, MaterialId = 12, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 12, Grade = Grade.Twelfth,
                        Name = "Cells. Prokaryotic and Eukaryotic",
                        Description = "A lesson about the different types of cells and their differences."
                    },
                    new Lesson
                    {
                        Id = 13, VideoId = 13, MaterialId = 13, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 13, Grade = Grade.Mixed, Name = "Acids, Bases and pH",
                        Description = "A lesson about acids, they effects on the environtment and usage cases."
                    },
                    new Lesson
                    {
                        Id = 14, VideoId = 14, MaterialId = 14, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 14, Grade = Grade.Fifth, Name = "Popular music",
                        Description = "Genres, instruments and notation."
                    },
                    new Lesson
                    {
                        Id = 15, VideoId = 15, MaterialId = 15, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 15, Grade = Grade.First, Name = "Painting",
                        Description = "Pigments, brushes, bases, matrices."
                    },
                    new Lesson
                    {
                        Id = 16, VideoId = 16, MaterialId = 16, ApplicationUserId = GlobalConstants.ApplicationAdministratorId,
                        IsApproved = true,
                        CategoryId = 16, Grade = Grade.Second, Name = "Entrepreneurship",
                        Description =
                            "Creating a new business, bearing most of the risks and enjoying most of the rewards."
                    });
            }
        }
    }
}

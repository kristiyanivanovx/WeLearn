using System;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.Shared;

namespace WeLearn.Data.Seeding
{
    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var categoriesCount = dbContext.Categories.Count();
            if (categoriesCount == 0)
            {
                await dbContext.Categories.AddRangeAsync(
                    new Category { Id = 1, Name = "Bulgarian Language" },
                    new Category { Id = 2, Name = "Mathematics" },
                    new Category { Id = 3, Name = "Informatics" },
                    new Category { Id = 4, Name = "IT" },
                    new Category { Id = 5, Name = "Geography" },
                    new Category { Id = 6, Name = "Physical Education and Sport" },
                    new Category { Id = 7, Name = "Literature" },
                    new Category { Id = 8, Name = "Civic Education" },
                    new Category { Id = 9, Name = "English Language" },
                    new Category { Id = 10, Name = "Russian Language" },
                    new Category { Id = 11, Name = "History" },
                    new Category { Id = 12, Name = "Biology" },
                    new Category { Id = 13, Name = "Chemistry" },
                    new Category { Id = 14, Name = "Music" },
                    new Category { Id = 15, Name = "Art" },
                    new Category { Id = 16, Name = "Technologies and Entrepreneurship" },
                    new Category { Id = 17, Name = "Others" });
            }
        }
    }
}

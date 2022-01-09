using System;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

namespace WeLearn.Data.Seeding
{
    public class MaterialsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var materialsCount = dbContext.Materials.Count();
            if (materialsCount == 0)
            {
                await dbContext.Materials.AddRangeAsync(
                    new Material
                    {
                        Id = 1, LessonId = 1, Name = "Teaching",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 2, LessonId = 2, Name = "Teaching",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 3, LessonId = 3, Name = "Coding",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 4, LessonId = 4, Name = "Office Suite",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 5, LessonId = 5, Name = "Ukraine",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 6, LessonId = 6, Name = "Football",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 7, LessonId = 7, Name = "Literature",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 8, LessonId = 8, Name = "Human Rights",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 9, LessonId = 9, Name = "Modal Verbs",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 10, LessonId = 10, Name = "Russian Language",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 11, LessonId = 11, Name = "History",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 12, LessonId = 12, Name = "Biology",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 13, LessonId = 13, Name = "Chemistry",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 14, LessonId = 14, Name = "Music",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 15, LessonId = 15, Name = "Painting",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    },
                    new Material
                    {
                        Id = 16, LessonId = 16, Name = "Entrepreneurship",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip"
                    });
            }
        }
    }
}

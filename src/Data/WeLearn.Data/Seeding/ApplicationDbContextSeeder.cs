using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WeLearn.Data.Seeding
{
    public class ApplicationDbContextSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(ApplicationDbContextSeeder));

            var seeders = new List<ISeeder>
            {
                new RolesSeeder(),
                new HeadAdminSeeder(),
                new UsersSeeder(),
                new CategoriesSeeder(),
                new VideosSeeder(),
                new MaterialsSeeder(),
                new LessonsSeeder(),
                new CommentsSeeder(),
                new ReportsSeeder(),
            };

            foreach (var seeder in seeders)
            {
                await seeder.SeedAsync(dbContext, serviceProvider);
                logger.LogInformation(@"Seeder {0} done", seeder.GetType().Name);
            }

            await dbContext.SaveChangesAsync();
            logger.LogInformation("All seeders have completed");
        }
    }
}

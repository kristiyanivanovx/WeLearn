using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WeLearn.Data.Seeding
{
    public class DatabaseContextSeeder : ISeeder
    {
        public async Task SeedAsync(DatabaseContext databaseContext, IServiceProvider serviceProvider)
        {
            if (databaseContext == null)
            {
                throw new ArgumentNullException(nameof(databaseContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(DatabaseContextSeeder));

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
                await seeder.SeedAsync(databaseContext, serviceProvider);
                logger.LogInformation(@"Seeder {0} done", seeder.GetType().Name);
            }

            await databaseContext.SaveChangesAsync();
            logger.LogInformation("All seeders have completed");
        }
    }
}

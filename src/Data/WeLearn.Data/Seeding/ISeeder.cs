using System;
using System.Threading.Tasks;

namespace WeLearn.Data.Seeding
{
    public interface ISeeder
    {
        Task SeedAsync(DatabaseContext databaseContext, IServiceProvider serviceProvider);
    }
}

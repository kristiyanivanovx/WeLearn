using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Models.Identity;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var headAdminUser = dbContext.ApplicationUsers.FirstOrDefault(x => x.Id == ApplicationAdministratorId);

            if (headAdminUser == null)
            {
                ApplicationUser applicationUser = new ApplicationUser
                {
                    Email = "default@gmail.com",
                    EmailConfirmed = false,
                    NormalizedEmail = "default@gmail.com".ToUpper(),
                    UserName = "Username",
                    NormalizedUserName = "Username".ToUpper(),
                };

                PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
                applicationUser.PasswordHash = passwordHasher.HashPassword(applicationUser, "User_qwerty_1234%");

                await dbContext.ApplicationUsers.AddAsync(applicationUser);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}

using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Models;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            ApplicationUser applicationUser = new ApplicationUser
            {
                Id = SeededUserId,
                Email = "default@gmail.com",
                EmailConfirmed = false,
                NormalizedEmail = "default@gmail.com".ToUpper(),
                UserName = "Username",
                NormalizedUserName = "Username".ToUpper(),
            };

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            applicationUser.PasswordHash = passwordHasher.HashPassword(applicationUser, "User_qwerty_1234%");

            // modelBuilder.Entity<ApplicationUser>().HasData(applicationUser);
            await dbContext.Users.AddAsync(applicationUser);
            // await dbContext.ApplicationUsers.AddAsync(applicationUser);
        }
    }
}

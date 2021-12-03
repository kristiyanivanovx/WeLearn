using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WeLearn.Data.Models;
using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class HeadAdminSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var user = await userManager.FindByEmailAsync(ApplicationAdministratorEmail);

            if (user == null)
            {
                ApplicationUser applicationUser = new ApplicationUser
                {
                    Id = SeededUserId,
                    Email = ApplicationAdministratorEmail,
                    EmailConfirmed = false,
                    UserName = ApplicationAdministratorUsername,
                    NormalizedEmail = ApplicationAdministratorEmail.ToUpper(),
                    NormalizedUserName = ApplicationAdministratorUsername.ToUpper(),
                };

                PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
                applicationUser.PasswordHash = passwordHasher.HashPassword(applicationUser, "admin_Pass123%");
                IdentityResult result = await userManager.CreateAsync(applicationUser);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(applicationUser, ApplicationAdministratorRoleName);
                    await userManager.AddToRoleAsync(applicationUser, ApplicationHeadAdministratorRoleName);
                }
            }
        }
    }
}

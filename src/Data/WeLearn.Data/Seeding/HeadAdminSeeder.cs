using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WeLearn.Data.Models.Identity;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class HeadAdminSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var user = await userManager.FindByEmailAsync(ApplicationHeadAdministratorEmail);

            if (user == null)
            {
                ApplicationUser applicationUser = new ApplicationUser
                {
                    Id = ApplicationHeadAdministratorId,
                    Email = ApplicationHeadAdministratorEmail,
                    EmailConfirmed = false,
                    UserName = ApplicationHeadAdministratorUsername,
                    NormalizedEmail = ApplicationHeadAdministratorEmail.ToUpper(),
                    NormalizedUserName = ApplicationHeadAdministratorUsername.ToUpper(),
                };

                PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
                applicationUser.PasswordHash = passwordHasher.HashPassword(applicationUser, "admin_Pass123%");
                IdentityResult result = await userManager.CreateAsync(applicationUser);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(applicationUser, ApplicationRegularAdministratorRoleName);
                    await userManager.AddToRoleAsync(applicationUser, ApplicationHeadAdministratorRoleName);
                }
            }
        }
    }
}

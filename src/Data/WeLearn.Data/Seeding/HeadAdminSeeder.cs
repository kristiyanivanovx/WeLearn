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
        public async Task SeedAsync(DatabaseContext databaseContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var user = await userManager.FindByEmailAsync(SystemHeadAdministratorEmail);

            if (user == null)
            {
                ApplicationUser applicationUser = new ApplicationUser
                {
                    Id = SystemHeadAdministratorId,
                    Email = SystemHeadAdministratorEmail,
                    EmailConfirmed = false,
                    UserName = SystemHeadAdministratorUsername,
                    NormalizedEmail = SystemHeadAdministratorEmail.ToUpper(),
                    NormalizedUserName = SystemHeadAdministratorUsername.ToUpper(),
                };

                PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
                applicationUser.PasswordHash = passwordHasher.HashPassword(applicationUser, "admin_Pass123%");
                IdentityResult result = await userManager.CreateAsync(applicationUser);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(applicationUser, SystemRegularAdministratorRoleName);
                    await userManager.AddToRoleAsync(applicationUser, SystemHeadAdministratorRoleName);
                }
            }
        }
    }
}

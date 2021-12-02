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

            if (userManager.FindByEmailAsync(ApplicationAdministratorEmail).Result == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    Email = ApplicationAdministratorEmail,
                    EmailConfirmed = false,
                    UserName = ApplicationAdministratorUsername,
                    NormalizedEmail = ApplicationAdministratorEmail.ToUpper(),
                    NormalizedUserName = ApplicationAdministratorUsername.ToUpper(),
                };

                IdentityResult result = userManager.CreateAsync(user, "admin_Pass123%").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, ApplicationAdministratorRoleName).Wait();
                    userManager.AddToRoleAsync(user, ApplicationHeadAdministratorRoleName).Wait();
                }
            }
        }
    }
}

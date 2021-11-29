using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Models;
using static WeLearn.Common.Constants;

namespace WeLearn.Data.Infrastructure
{
    public static class ApplicationDbInitializer
    {
        public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedHeadAdminUser(userManager);
        }

        private static void SeedRoles(RoleManager<ApplicationRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(ApplicationAdministratorRoleName).Result)
            {
                ApplicationRole role = new ApplicationRole(ApplicationAdministratorRoleName);
                _ = roleManager.CreateAsync(role).Result;
            }
            
            if (!roleManager.RoleExistsAsync(ApplicationHeadAdministratorRoleName).Result)
            {
                ApplicationRole role = new ApplicationRole(ApplicationHeadAdministratorRoleName);
                _ = roleManager.CreateAsync(role).Result;
            }
        }

        private static void SeedHeadAdminUser(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByEmailAsync(ApplicationAdministratorEmail).Result == null)
            {
                ApplicationUser user = new ApplicationUser()
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

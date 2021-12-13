using System;

using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Identity;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Infrastructure
{
    public static class ApplicationDbInitializer
    {
        public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedRoles(RoleManager<ApplicationRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(ApplicationAdministratorRoleName).Result)
            {
                ApplicationRole role = new ApplicationRole(ApplicationAdministratorRoleName);
                role.CreatedOn = DateTime.UtcNow;
                _ = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(ApplicationHeadAdministratorRoleName).Result)
            {
                ApplicationRole role = new ApplicationRole(ApplicationHeadAdministratorRoleName);
                role.CreatedOn = DateTime.UtcNow;
                _ = roleManager.CreateAsync(role).Result;
            }
        }

        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            var headAdmin = userManager.FindByEmailAsync(ApplicationAdministratorEmail).Result;

            // Head Admin doesn't exist, create him and add him to HeadAdmin and Admin roles
            if (headAdmin == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    Id = ApplicationAdministratorId,
                    Email = ApplicationAdministratorEmail,
                    EmailConfirmed = false,
                    UserName = ApplicationAdministratorUsername,
                    NormalizedEmail = ApplicationAdministratorEmail.ToUpper(),
                    NormalizedUserName = ApplicationAdministratorUsername.ToUpper(),
                    CreatedOn = DateTime.UtcNow,
                };

                IdentityResult result = userManager.CreateAsync(user, "admin_Pass123%").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, ApplicationAdministratorRoleName).Wait();
                    userManager.AddToRoleAsync(user, ApplicationHeadAdministratorRoleName).Wait();
                }
            }
            else
            {
                // Head Admin does exist, ensure he is in HeadAdmin and Admin roles
                var isInAdminRole = userManager.IsInRoleAsync(headAdmin, ApplicationAdministratorRoleName).GetAwaiter().GetResult();
                var isInHeadAdminRole = userManager.IsInRoleAsync(headAdmin, ApplicationHeadAdministratorRoleName).GetAwaiter().GetResult();

                if (!isInAdminRole)
                {
                    userManager.AddToRoleAsync(headAdmin, ApplicationAdministratorRoleName).GetAwaiter().GetResult();
                }

                if (!isInHeadAdminRole)
                {
                    userManager.AddToRoleAsync(headAdmin, ApplicationHeadAdministratorRoleName).GetAwaiter().GetResult();
                }
            }
        }
    }
}

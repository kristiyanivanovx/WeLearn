using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;

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
            List<string> roles = new List<string>
            {
                ApplicationRegularAdministratorRoleName,
                ApplicationHeadAdministratorRoleName,
                ApplicationTeacherRoleName
            };

            foreach (var role in roles)
            {
                if (!roleManager.RoleExistsAsync(role).Result)
                {
                    ApplicationRole applicationRole = new ApplicationRole(role)
                    {
                        CreatedOn = DateTime.UtcNow
                    };

                    roleManager.CreateAsync(applicationRole).GetAwaiter().GetResult();
                }
            }
        }

        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            // seed Teacher
            var teacherUser = userManager.FindByEmailAsync(ApplicationTeacherEmail).Result;

            // Teacher doesn't exist, create him and add him to the teacher role
            if (teacherUser == null)
            {
                var roles = new[]
                {
                    ApplicationTeacherRoleName
                };

                CreateUser(
                    userManager,
                    ApplicationTeacherId,
                    ApplicationTeacherEmail,
                    false,
                    ApplicationTeacherUsername,
                    "Peter_1234_#pass",
                    roles);
            }
            else
            {
                // Teacher does exist, ensure he is in the Teacher roles
                EnsureUserInRole(userManager, teacherUser, ApplicationTeacherRoleName);
            }

            // seed Regular Admin
            var regularAdmin = userManager.FindByEmailAsync(ApplicationRegularAdministratorEmail).Result;

            // Regular Admin doesn't exist, create him and add him to Admin roles
            if (regularAdmin == null)
            {
                var roles = new[]
                {
                    ApplicationRegularAdministratorRoleName,
                };

                CreateUser(
                    userManager,
                    ApplicationRegularAdministratorId,
                    ApplicationRegularAdministratorEmail,
                    false,
                    ApplicationRegularAdministratorUsername,
                    "User_qwerty_1234%",
                    roles);
            }
            else
            {
                // Regular Admin does exist, ensure he is in Admin role
                EnsureUserInRole(userManager, regularAdmin, ApplicationRegularAdministratorRoleName);
            }

            // seed Head Admin
            var headAdmin = userManager.FindByEmailAsync(ApplicationHeadAdministratorEmail).Result;

            // Head Admin doesn't exist, create him and add him to HeadAdmin and Admin roles
            if (headAdmin == null)
            {
                var roles = new[]
                {
                    ApplicationRegularAdministratorRoleName,
                    ApplicationHeadAdministratorRoleName
                };

                CreateUser(
                    userManager,
                    ApplicationHeadAdministratorId,
                    ApplicationHeadAdministratorEmail,
                    false,
                    ApplicationHeadAdministratorUsername,
                    "admin_Pass123%",
                    roles);
            }
            else
            {
                // Head Admin does exist, ensure he is in HeadAdmin and Admin roles
                EnsureUserInRole(userManager, headAdmin, ApplicationRegularAdministratorRoleName);
                EnsureUserInRole(userManager, headAdmin, ApplicationHeadAdministratorRoleName);
            }
        }

        private static void CreateUser(
            UserManager<ApplicationUser> userManager,
            string id,
            string email,
            bool emailConfirmed,
            string userName,
            string password,
            string[] rolesToAdd)
        {
            ApplicationUser user = new ApplicationUser
            {
                Id = id,
                Email = email,
                EmailConfirmed = emailConfirmed,
                UserName = userName,
                NormalizedEmail = email.ToUpper(),
                NormalizedUserName = userName.ToUpper(),
                CreatedOn = DateTime.UtcNow,
            };

            IdentityResult result = userManager.CreateAsync(user, password).Result;
            if (result.Succeeded)
            {
                foreach (var role in rolesToAdd)
                {
                    userManager.AddToRoleAsync(user, role).Wait();
                }
            }
        }

        private static void EnsureUserInRole(UserManager<ApplicationUser> userManager, ApplicationUser user, string roleName)
        {
            var isInRole = userManager.IsInRoleAsync(user, roleName).GetAwaiter().GetResult();
            if (!isInRole)
            {
                userManager.AddToRoleAsync(user, roleName).GetAwaiter().GetResult();
            }
        }
    }
}

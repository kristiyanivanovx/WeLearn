using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Models;

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
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                ApplicationRole role = new ApplicationRole("Admin");
                _ = roleManager.CreateAsync(role).Result;
            }
        }

        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByEmailAsync("welearnbg@gmail.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "welearnbg@gmail.com",
                    EmailConfirmed = false,
                    UserName = "welearnbg@gmail.com",
                    NormalizedEmail = "WELEARNBG@GMAIL.COM",
                    NormalizedUserName = "WELEARNBG@GMAIL.COM",
                };

                IdentityResult result = userManager.CreateAsync(user, "admin_Pass123%").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}

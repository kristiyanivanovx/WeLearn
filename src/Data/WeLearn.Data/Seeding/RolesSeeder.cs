using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WeLearn.Data.Models;
using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Data.Seeding
{
    public class RolesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            await SeedRoleAsync(roleManager, ApplicationAdministratorRoleName);
        }

        private static async Task SeedRoleAsync(RoleManager<ApplicationRole> roleManager, string roleName)
        {
            if (!roleManager.RoleExistsAsync(ApplicationAdministratorRoleName).Result)
            {
                ApplicationRole adminRole = new ApplicationRole(ApplicationAdministratorRoleName);
                _ = roleManager.CreateAsync(adminRole).Result;
            }

            if (!roleManager.RoleExistsAsync(ApplicationHeadAdministratorRoleName).Result)
            {
                ApplicationRole headAdminRole = new ApplicationRole(ApplicationHeadAdministratorRoleName);
                _ = roleManager.CreateAsync(headAdminRole).Result;
            }

            var role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                var result = await roleManager.CreateAsync(new ApplicationRole(roleName));
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}

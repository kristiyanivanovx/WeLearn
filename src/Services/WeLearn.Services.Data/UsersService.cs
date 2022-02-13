using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Identity;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Services.Mapping;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Services.Data
{
    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> appUserRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public UsersService(
            IDeletableEntityRepository<ApplicationUser> appUserRepository,
            UserManager<ApplicationUser> userManager)
        {
            this.appUserRepository = appUserRepository;
            this.userManager = userManager;
        }

        public int GetCount()
            => this.appUserRepository.All().Count();

        public async Task<IEnumerable<string>> GetRoleNamesByUserId(string userId)
        {
            var user = await this.userManager.FindByIdAsync(userId);
            var roles = this.userManager
                .GetRolesAsync(user)
                .Result
                .OrderBy(x => x.Length)
                .ToList();

            return roles;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
            => await this.appUserRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == userId);

        public async Task<ApplicationUser> GetUserByUsernameAsync(string username)
            => await this.appUserRepository
                .All()
                .FirstOrDefaultAsync(x => x.UserName == username);

        public async Task<IEnumerable<T>> GetAllUsersAsync<T>(string searchString)
        {
            IQueryable<ApplicationUser> users = this.appUserRepository.All();

            if (!string.IsNullOrEmpty(searchString))
            {
                var searchStringLowerCase = searchString.ToLower();

                users = users.Where(x =>
                    x.UserName.ToLower().Contains(searchStringLowerCase) ||
                    x.Email.ToLower().Contains(searchStringLowerCase));
            }

            T[] usersViewModels = await users.To<T>().ToArrayAsync();

            return usersViewModels;
        }

        public async Task ToggleAdminRoleAsync(string userId)
        {
            var user = await this.appUserRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == userId);

            var isAdmin = await this.userManager.IsInRoleAsync(user, SystemRegularAdministratorRoleName);
            var isHeadAdmin = await this.userManager.IsInRoleAsync(user, SystemHeadAdministratorRoleName);

            // if HeadAdmin is trying to remove his Admin role, restrict him
            if (isHeadAdmin)
            {
                return;
            }

            // if HeadAdmin is trying to toggle Admin role on an User
            if (isAdmin)
            {
                await this.userManager.RemoveFromRoleAsync(user, SystemRegularAdministratorRoleName);
            }
            else
            {
                await this.userManager.AddToRoleAsync(user, SystemRegularAdministratorRoleName);
            }

            await this.appUserRepository.SaveChangesAsync();
        }

        public async Task ToggleTeacherRoleAsync(string targetUserId, string actingUserId)
        {
            var actingUser = await this.appUserRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == actingUserId);

            var targetUser = await this.appUserRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == targetUserId);

            // regular admins should not be able to touch head admin's teacher role
            // this is when (acting user is not admin) and (target is head admin)
            var isActingUserHeadAdmin = await this.userManager.IsInRoleAsync(actingUser, SystemHeadAdministratorRoleName);
            var isTargetUserHeadAdmin = await this.userManager.IsInRoleAsync(targetUser, SystemHeadAdministratorRoleName);

            if (!isActingUserHeadAdmin && isTargetUserHeadAdmin)
            {
                return;
            }

            var isUserTeacher = await this.userManager.IsInRoleAsync(targetUser, SystemTeacherRoleName);
            if (isUserTeacher)
            {
                await this.userManager.RemoveFromRoleAsync(targetUser, SystemTeacherRoleName);
            }
            else
            {
                await this.userManager.AddToRoleAsync(targetUser, SystemTeacherRoleName);
            }

            await this.appUserRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersExceptAsync(string userId)
            => await this.appUserRepository
                .All()
                .Where(x => x.Id != userId)
                .ToListAsync();

        public async Task<T> GetUserByIdAsync<T>(string userId)
            => await this.appUserRepository
                .All()
                .Where(x => x.Id == userId)
                .To<T>()
                .FirstOrDefaultAsync();

        public async Task SoftDeleteUserByIdAsync(string userId)
        {
            var user = this.appUserRepository
                .AllWithDeleted()
                .FirstOrDefault(x => x.Id == userId);

            this.appUserRepository.Delete(user);
            await this.appUserRepository.SaveChangesAsync();
        }

        public async Task HardDeleteUserByIdAsync(string userId)
        {
            var user = this.appUserRepository
                .All()
                .FirstOrDefault(x => x.Id == userId);

            var isUserHeadAdmin = await this.userManager.IsInRoleAsync(user, SystemHeadAdministratorRoleName);
            if (isUserHeadAdmin)
            {
                return;
            }

            if (user != null)
            {
                this.appUserRepository.HardDelete(user);
            }

            await this.appUserRepository.SaveChangesAsync();
        }
    }
}

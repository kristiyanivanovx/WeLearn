using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;

using static WeLearn.Common.GlobalConstants;

namespace WeLearn.Services
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

        public int GetAllUsersCount()
            => this.appUserRepository.All().Count();

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
                users = users.Where(x => x.UserName.ToLower().Contains(searchStringLowerCase) ||
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

            var isAdmin = await this.userManager.IsInRoleAsync(user, ApplicationAdministratorRoleName);
            var isHeadAdmin = await this.userManager.IsInRoleAsync(user, ApplicationHeadAdministratorRoleName);

            // if HeadAdmin is trying to remove his Admin role, restrict him
            if (isHeadAdmin)
            {
                return;
            }

            // if HeadAdmin is trying to toggle Admin role on an User
            if (isAdmin)
            {
                await this.userManager.RemoveFromRoleAsync(user, ApplicationAdministratorRoleName);
            }
            else
            {
                await this.userManager.AddToRoleAsync(user, ApplicationAdministratorRoleName);
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
            var user = this.appUserRepository.All().FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                this.appUserRepository.HardDelete(user);
            }

            await this.appUserRepository.SaveChangesAsync();
        }
    }
}

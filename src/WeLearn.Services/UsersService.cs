using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;

using static WeLearn.Common.Constants;

namespace WeLearn.Services
{
    public class UsersService : IUsersService
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public UsersService(
            IMapper mapper,
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public int GetAllUsersCount()
            => this.context.Users.Count();

        public async Task<ApplicationUser> GetUserByUsernameAsync(string username)
            => await this.context.ApplicationUsers
                .FirstOrDefaultAsync(x => x.UserName == username);

        public async Task<IEnumerable<T>> GetAllUsersAsync<T>(string searchString)
        {
            IQueryable<ApplicationUser> users = this.context.ApplicationUsers;

            if (!string.IsNullOrEmpty(searchString))
            {
                var searchStringLowerCase = searchString.ToLower();
                users = users.Where(x => x.UserName.ToLower().Contains(searchStringLowerCase) ||
                                         x.Email.ToLower().Contains(searchStringLowerCase));
            }

            await users.ToListAsync();

            T[] usersViewModels = this.mapper.Map<T[]>(users);

            return usersViewModels;
        }

        public async Task ToggleAdminRoleAsync(string userId)
        {
            var user = await this.context.ApplicationUsers
                .FirstOrDefaultAsync(x => x.Id == userId);

            var isAdmin = await this.userManager.IsInRoleAsync(user, ApplicationAdministratorRoleName);

            if (isAdmin)
            {
                await this.userManager.RemoveFromRoleAsync(user, ApplicationAdministratorRoleName);
            }
            else
            {
                await this.userManager.AddToRoleAsync(user, ApplicationAdministratorRoleName);
            }

            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersExceptAsync(string userId)
            => await this.context.ApplicationUsers
                .Where(x => x.Id != userId)
                .ToListAsync();

        public async Task<T> GetUserByIdAsync<T>(string userId)
        {
            var user = await this.context.ApplicationUsers
                .Where(x => x.Id == userId)
                .FirstOrDefaultAsync();

            T userMapped = this.mapper.Map<T>(user);

            return userMapped;
        }

        public async Task SoftDeleteUserByIdAsync(string userId)
        {
            // todo: implement, check if works with service
            var user = this.context.ApplicationUsers
                .FirstOrDefault(x => x.Id == userId);

            // var user = await this.GetUserByIdAsync(userId);
            // user.IsDeleted = true;
            await this.context.SaveChangesAsync();
        }

        public async Task HardDeleteUserByIdAsync(string userId)
        {
            var user = this.context.Users.FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                this.context.ApplicationUsers.Remove(user);
            }

            await this.context.SaveChangesAsync();
        }
    }
}

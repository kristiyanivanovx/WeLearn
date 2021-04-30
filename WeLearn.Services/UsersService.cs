using WeLearn.Services.Interfaces;
using WeLearn.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WeLearn.Services
{
    public class UsersService : IUsersService
    {
        //private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext context;

        public UsersService(
            //UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            //this.userManager = userManager;
            this.context = context;
        }

        public async Task<int> GetAllUsersCountAsync()
        {
            var usersCount = context.Users.CountAsync();
            return await usersCount;
        }
    }
}

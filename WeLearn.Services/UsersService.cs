using WeLearn.Services.Interfaces;
using WeLearn.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WeLearn.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext context;

        public UsersService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<int> GetAllUsersCountAsync()
        {
            var usersCount = context.Users.CountAsync();
            return await usersCount;
        }
    }
}

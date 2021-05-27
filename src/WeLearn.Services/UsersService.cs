using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext context;

        public UsersService(ApplicationDbContext context)
            => this.context = context;

        public async Task<IEnumerable<ApplicationUser>> GetUsersAsync(string userId)
            => await this.context.ApplicationUsers
                .Where(x => x.Id != userId)
                .ToListAsync();

        public int GetAllUsersCount()
            => this.context.Users.Count();
    }
}

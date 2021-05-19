using WeLearn.Services.Interfaces;
using WeLearn.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using WeLearn.Data.Models;
using System.Collections.Generic;

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

using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;

namespace WeLearn.Services.Interfaces
{
    public interface IUsersService
    {
        int GetAllUsersCount();

        Task<IEnumerable<ApplicationUser>> GetUsersAsync(string userId);
    }
}

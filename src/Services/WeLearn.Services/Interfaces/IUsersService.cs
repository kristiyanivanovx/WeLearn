using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;

namespace WeLearn.Services.Interfaces
{
    public interface IUsersService
    {
        int GetAllUsersCount();

        Task<ApplicationUser> GetUserByUsernameAsync(string username);

        Task<IEnumerable<T>> GetAllUsersAsync<T>(string searchString);

        Task ToggleAdminRoleAsync(string userId);
        
        Task<IEnumerable<ApplicationUser>> GetUsersExceptAsync(string userId);

        Task<T> GetUserByIdAsync<T>(string userId);

        Task SoftDeleteUserByIdAsync(string userId);

        Task HardDeleteUserByIdAsync(string userId);
    }
}

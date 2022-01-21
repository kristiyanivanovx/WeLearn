using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Identity;

namespace WeLearn.Services.Interfaces
{
    public interface IUsersService
    {
        int GetCount();

        Task<IEnumerable<string>> GetRoleNamesByUserId(string userId);

        Task<ApplicationUser> GetUserByUsernameAsync(string username);

        Task<IEnumerable<T>> GetAllUsersAsync<T>(string searchString);

        Task ToggleAdminRoleAsync(string userId);

        Task ToggleTeacherRoleAsync(string targetUserId, string actingUserId);

        Task<IEnumerable<ApplicationUser>> GetUsersExceptAsync(string userId);

        Task<ApplicationUser> GetUserByIdAsync(string userId);

        Task<T> GetUserByIdToModelAsync<T>(string userId);

        Task SoftDeleteUserByIdAsync(string userId);

        Task HardDeleteUserByIdAsync(string userId);
    }
}

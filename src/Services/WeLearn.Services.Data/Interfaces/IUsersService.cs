using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Identity;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IUsersService
    {
        int GetCount();

        Task<IEnumerable<string>> GetRoleNamesByUserId(string userId);

        Task<ApplicationUser> GetByUsernameAsync(string username);

        Task<IEnumerable<T>> GetAllAsync<T>(string searchString);

        Task ToggleAdminRoleAsync(string userId);

        Task ToggleTeacherRoleAsync(string targetUserId, string actingUserId);

        Task<IEnumerable<ApplicationUser>> GetExceptByIdAsync(string userId);

        Task<ApplicationUser> GetByIdAsync(string userId);

        Task<T> GetByIdAsync<T>(string userId);

        Task SoftDeleteByIdAsync(string userId);

        Task HardDeleteByIdAsync(string userId);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.User;
using WeLearn.Web.ViewModels.Organization;

namespace WeLearn.Services.Data.Interfaces
{
    public interface IOrganizationsService
    {
        IEnumerable<T> GetAllAsync<T>(bool includeDeleted = false);

        IEnumerable<T> GetByCreatorId<T>(string userId);

        IEnumerable<T> GetByMemberId<T>(string memberId);

        T GetById<T>(int id, bool includeDeleted = false);

        Task AddUserAsync(int orgId, string userId);

        Task RemoveUserAsync(int orgId, string userId);

        Organization GetById(int id, bool includeDeleted = false);

        Task EditAsync(OrganizationEditModel model, bool includeDeleted = false);

        Task SoftDeleteAsync(int id, string userId);

        Task<int> CreateAsync(OrganizationInputModel model, string userId);

        Task HardDeleteAsync(int id, bool includeDeleted = false);
    }
}

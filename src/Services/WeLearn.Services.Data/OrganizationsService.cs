using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Identity;
using WeLearn.Data.Models.User;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Organization;

namespace WeLearn.Services.Data
{
    // todo: interface
    public class OrganizationsService
    {
        private readonly IUsersService usersService;
        private readonly IDeletableEntityRepository<ApplicationUser> appUserRepository;
        private readonly IDeletableEntityRepository<Organization> organizationRepository;

        public OrganizationsService(
            IUsersService usersService,
            IDeletableEntityRepository<Organization> organizationRepository,
            IDeletableEntityRepository<ApplicationUser> appUserRepository)
        {
            this.usersService = usersService;
            this.organizationRepository = organizationRepository;
            this.appUserRepository = appUserRepository;
        }

        public IEnumerable<T> GetAllAsync<T>(bool includeDeleted = false)
        {
            var query = includeDeleted ?
                this.organizationRepository.AllWithDeleted() :
                this.organizationRepository.All();

            return query
                .To<T>()
                .ToList();
        }

        public IEnumerable<T> GetByCreatorId<T>(string userId)
            => this.organizationRepository
                .All()
                .Include(x => x.Users)
                .Where(x => x.CreatorId == userId)
                .To<T>()
                .ToList();

        public IEnumerable<T> GetByMemberId<T>(string memberId)
            => this.organizationRepository
                .All()
                .Include(x => x.Users)
                .Where(x => x.Users.Any(u => u.Id == memberId))
                .To<T>()
                .ToList();

        public T GetByIdAsync<T>(int id, bool includeDeleted = false)
        {
            var query = includeDeleted ?
                this.organizationRepository.AllWithDeleted() :
                this.organizationRepository.All();

            return query
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }

        public async Task AddUserToOrganizationAsync(int orgId, string userId)
        {
            var organization = this.GetById(orgId);
            var user = await this.usersService.GetUserByIdAsync(userId);

            organization?.Users.Add(user);
            await this.organizationRepository.SaveChangesAsync();
        }

        public async Task RemoveUserFromOrganization(int orgId, string userId)
        {
            var organization = this.GetById(orgId);
            var user = await this.usersService.GetUserByIdAsync(userId);

            organization?.Users.Remove(user);
            this.organizationRepository.Update(organization);

            await this.appUserRepository.SaveChangesAsync();
            await this.organizationRepository.SaveChangesAsync();
        }

        public Organization GetById(int id, bool includeDeleted = false)
        {
            var query = includeDeleted ?
                this.organizationRepository.AllWithDeleted() :
                this.organizationRepository.All();

            return query
                .Include(x => x.Users)
                .FirstOrDefault(x => x.Id == id);
        }

        public async Task EditAsync(OrganizationEditModel model, bool includeDeleted = false)
        {
            var organization = this.GetById(model.Id, includeDeleted);

            organization.Name = model.Name;
            organization.Description = model.Description;
            organization.IsDeleted = model.IsDeleted;

            this.organizationRepository.Update(organization);
            await this.organizationRepository.SaveChangesAsync();
        }

        public async Task SoftDeleteAsync(int id, string userId)
        {
            var organization = this.GetById(id);
            if (organization.CreatorId.Equals(userId))
            {
                this.organizationRepository.Delete(organization);
                await this.organizationRepository.SaveChangesAsync();
            }
        }

        public async Task<int> CreateAsync(OrganizationInputModel model, string userId)
        {
            var organization = new Organization
            {
                Name = model.Name,
                Description = model.Description,
                CreatorId = userId,
            };

            await this.organizationRepository.AddAsync(organization);
            await this.organizationRepository.SaveChangesAsync();

            return organization.Id;
        }

        public async Task HardDeleteAsync(int id, bool includeDeleted = false)
        {
            var query = includeDeleted
                ? this.organizationRepository.AllWithDeleted()
                : this.organizationRepository.All();

            var organization = query.FirstOrDefault(x => x.Id == id);

            this.organizationRepository.HardDelete(organization);
            await this.organizationRepository.SaveChangesAsync();
        }
    }
}

using System.Threading.Tasks;

using Moq;
using WeLearn.Data.Models.Identity;
using WeLearn.Data.Models.User;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Tests.Mocks;
using WeLearn.Web.ViewModels.Organization;
using Xunit;

namespace WeLearn.Tests
{
    public class OrganizationsServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_OrganizationCreated()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var organizationRepository = new EfDeletableEntityRepository<Organization>(dbInstance);
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(dbInstance);
            var usersServiceMock = new Mock<IUsersService>();

            var organizationsService = new OrganizationsService(
                usersServiceMock.Object,
                organizationRepository,
                appUserRepository);

            var model = new OrganizationInputModel
            {
                Name = 123.ToString(),
                Description = 123.ToString(),
            };

            // act
            await organizationsService.CreateAsync(model, 123.ToString());
            var organization = organizationsService.GetById(1, true);

            // assert
            Assert.NotNull(organization);
        }

        [Fact]
        public async Task Should_Succeed_When_OrganizationSoftDeleted()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var organizationRepository = new EfDeletableEntityRepository<Organization>(dbInstance);
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(dbInstance);
            var usersServiceMock = new Mock<IUsersService>();

            var organizationsService = new OrganizationsService(
                usersServiceMock.Object,
                organizationRepository,
                appUserRepository);

            var model = new OrganizationInputModel
            {
                Name = 123.ToString(),
                Description = 123.ToString(),
            };

            var userId = 123.ToString();

            // act
            await organizationsService.CreateAsync(model, userId);
            await organizationsService.SoftDeleteAsync(1, userId);

            var organization = organizationsService.GetById(1);
            var organizationWhenIncludeDeleted = organizationsService.GetById(1, true);

            // assert
            Assert.Null(organization);
            Assert.NotNull(organizationWhenIncludeDeleted);
        }

        [Fact]
        public async Task Should_Succeed_When_OrganizationHardDeleted()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var organizationRepository = new EfDeletableEntityRepository<Organization>(dbInstance);
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(dbInstance);
            var usersServiceMock = new Mock<IUsersService>();

            var organizationsService = new OrganizationsService(
                usersServiceMock.Object,
                organizationRepository,
                appUserRepository);

            var model = new OrganizationInputModel
            {
                Name = 123.ToString(),
                Description = 123.ToString(),
            };

            // act
            await organizationsService.CreateAsync(model, 123.ToString());
            await organizationsService.HardDeleteAsync(1, true);

            var organization = organizationsService.GetById(1);
            var organizationWhenIncludeDeleted = organizationsService.GetById(1, true);

            // assert
            Assert.Null(organization);
            Assert.Null(organizationWhenIncludeDeleted);
        }

        [Fact]
        public async Task Should_Succeed_When_OrganizationEdited()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var organizationRepository = new EfDeletableEntityRepository<Organization>(dbInstance);
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(dbInstance);
            var usersServiceMock = new Mock<IUsersService>();

            var organizationsService = new OrganizationsService(
                usersServiceMock.Object,
                organizationRepository,
                appUserRepository);

            var createModel = new OrganizationInputModel
            {
                Name = 123.ToString(),
                Description = 123.ToString(),
            };

            // act
            await organizationsService.CreateAsync(createModel, 123.ToString());

            var editModel = new OrganizationEditModel
            {
                Id = 1,
                Name = 5.ToString(),
                Description = 5.ToString(),
            };

            await organizationsService.EditAsync(editModel);
            var organization = organizationsService.GetById(1);

            // assert
            Assert.NotNull(organization);
            Assert.Equal(5.ToString(), organization.Name);
            Assert.Equal(5.ToString(), organization.Description);
        }
    }
}

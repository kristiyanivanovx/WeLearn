using System.Threading.Tasks;

using WeLearn.Data.Models.Identity;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Models.Shared;
using WeLearn.Data.Repositories;

using WeLearn.Services.Data;
using WeLearn.Services.Mapping;
using WeLearn.Tests.Mocks;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.Comment;
using Xunit;

namespace WeLearn.Tests
{
    public class ViewComponentsServiceTests
    {
        // todo: fix when tested with "Tests" -> "Run All Tests from Solution"
        // [Fact]
        public async Task Should_Succeed_When_ViewComponentIsGenerated()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var categoryRepository = new EfDeletableEntityRepository<Category>(dbInstance);
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(dbInstance);
            var lessonsRepository = new EfDeletableEntityRepository<Lesson>(dbInstance);
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);

            var comment = new Comment { Content = "hi from test comment" };
            await commentRepository.AddAsync(comment);
            await commentRepository.SaveChangesAsync();

            var category = new Category { Name = "hi from test category 2" };
            await categoryRepository.AddAsync(category);
            await categoryRepository.SaveChangesAsync();
            AutoMapperConfig.RegisterMappings(typeof(CategoryViewModel).Assembly);
            AutoMapperConfig.RegisterMappings(typeof(CommentViewModel).Assembly);

            var viewComponentsService = new ViewComponentsService(
                commentRepository,
                categoryRepository,
                lessonsRepository,
                appUserRepository);

            // act
            var model = viewComponentsService.GenerateDropdownModel();

            // assert
            Assert.NotNull(model);
        }

        // todo: fix when tested with "Tests" -> "Run All Tests from Solution"
        // [Fact]
        public async Task Should_Succeed_When_ViewComponentCommentsRetrieved()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var categoryRepository = new EfDeletableEntityRepository<Category>(dbInstance);
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(dbInstance);
            var lessonsRepository = new EfDeletableEntityRepository<Lesson>(dbInstance);
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);

            var comment = new Comment { Content = "hi from test comment" };
            await commentRepository.AddAsync(comment);
            await commentRepository.SaveChangesAsync();

            var category = new Category { Name = "hi from test category 2" };
            await categoryRepository.AddAsync(category);
            await categoryRepository.SaveChangesAsync();
            AutoMapperConfig.RegisterMappings(typeof(CategoryViewModel).Assembly);
            AutoMapperConfig.RegisterMappings(typeof(CommentViewModel).Assembly);

            var viewComponentsService = new ViewComponentsService(
                commentRepository,
                categoryRepository,
                lessonsRepository,
                appUserRepository);

            // act
            var models = await viewComponentsService.GetCommentsAsync(1);

            // assert
            Assert.NotNull(models);
            Assert.Empty(models);
        }

        [Fact]
        public async Task Should_Succeed_When_UserCountZero()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var categoryRepository = new EfDeletableEntityRepository<Category>(dbInstance);
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(dbInstance);
            var lessonsRepository = new EfDeletableEntityRepository<Lesson>(dbInstance);
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);
            AutoMapperConfig.RegisterMappings(typeof(CategoryViewModel).Assembly);
            AutoMapperConfig.RegisterMappings(typeof(CommentViewModel).Assembly);

            var viewComponentsService = new ViewComponentsService(
                commentRepository,
                categoryRepository,
                lessonsRepository,
                appUserRepository);

            // act
            var usersCount = await viewComponentsService.GetUsersCount();

            // assert
            Assert.Equal(0, usersCount);
        }
    }
}

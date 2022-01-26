using System;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models.Identity;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Models.Shared;
using WeLearn.Data.Repositories;
using WeLearn.Services;
using WeLearn.Services.Data;
using WeLearn.Tests.Mocks;
using Xunit;

namespace WeLearn.Tests
{
    public class ViewComponentsServiceTests
    {
        // [Fact]
        public async Task Should_Succeed_When_ViewComponentIsBuilt()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var categoryRepository = new EfDeletableEntityRepository<Category>(dbInstance);
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(dbInstance);
            var lessonsRepository = new EfDeletableEntityRepository<Lesson>(dbInstance);
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);

            var comment = new Comment { Id = 1, Content = "hi from test comment" };
            await commentRepository.AddAsync(comment);
            await commentRepository.SaveChangesAsync();

            var category = new Category { Id = 1, Name = "hi from test category" };
            await categoryRepository.AddAsync(category);
            await categoryRepository.SaveChangesAsync();

            var viewComponentsService = new ViewComponentsService(
                commentRepository,
                categoryRepository,
                lessonsRepository,
                appUserRepository);

            // todo: fix not mapping models
            // act
            var navigationDropdownModel = viewComponentsService.GenerateDropdownModel();

            // assert
            Assert.NotNull(navigationDropdownModel);
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

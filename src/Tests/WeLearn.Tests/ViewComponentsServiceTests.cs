using System;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Identity;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Models.Shared;
using WeLearn.Data.Repositories;
using WeLearn.Services;
using Xunit;

namespace WeLearn.Tests
{
    public class ViewComponentsServiceTests
    {
        // [Fact]
        public async Task Should_Succeed_When_ViewComponentIsBuilt()
        {
            // arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var categoryRepository = new EfDeletableEntityRepository<Category>(new ApplicationDbContext(options));
            var appUserRepository = new EfDeletableEntityRepository<ApplicationUser>(new ApplicationDbContext(options));
            var lessonsRepository = new EfDeletableEntityRepository<Lesson>(new ApplicationDbContext(options));
            var commentRepository = new EfDeletableEntityRepository<Comment>(new ApplicationDbContext(options));

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
            // // act
            // var navigationDropdownModel = viewComponentsService.GenerateDropdownModel();
            //
            // // assert
            // Assert.NotNull(navigationDropdownModel);
        }
    }
}

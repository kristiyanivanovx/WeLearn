using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Data.Repositories;
using WeLearn.Services;
using Xunit;

namespace WeLearn.Tests
{
    public class CategoriesServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_CategoriesCountIsRetrieved()
        {
            // arrange
            var data = new List<Category>
            {
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" },
                new Category { Id = 3, Name = "Category 3" },
            }.AsQueryable();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var categoryRepository = new EfDeletableEntityRepository<Category>(new ApplicationDbContext(options));
            var service = new CategoriesService(categoryRepository);

            foreach (var category in data)
            {
                await categoryRepository.AddAsync(category);
                await categoryRepository.SaveChangesAsync();
            }

            // act
            int categoriesCount = service.GetAllCategoriesCount();

            // assert
            Assert.Equal(3, categoriesCount);
        }
    }
}

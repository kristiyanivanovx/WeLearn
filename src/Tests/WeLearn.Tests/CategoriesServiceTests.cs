using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Shared;
using WeLearn.Data.Repositories;

using WeLearn.Services.Data;
using WeLearn.Tests.Mocks;
using Xunit;

namespace WeLearn.Tests
{
    public class CategoriesServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_CategoriesCountIsRetrieved()
        {
            // var mapper = AutoMapperConfig.MapperInstance;

            // arrange
            var data = new List<Category>
            {
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" },
                new Category { Id = 3, Name = "Category 3" },
            };

            await using var dbInstance = DatabaseMock.Instance;
            var categoryRepository = new EfDeletableEntityRepository<Category>(dbInstance);
            var categoriesService = new CategoriesService(categoryRepository);

            // act
            foreach (var category in data)
            {
                await categoryRepository.AddAsync(category);
                await categoryRepository.SaveChangesAsync();
            }

            int categoriesCount = categoriesService.GetCount();

            // assert
            Assert.Equal(3, categoriesCount);
        }
    }
}

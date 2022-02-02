using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.Shared;
using WeLearn.Data.Repositories;

using WeLearn.Services.Data;
using WeLearn.Services.Mapping;
using WeLearn.Tests.Mocks;
using WeLearn.Web.ViewModels.Category;
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

        [Fact]
        public async Task Should_Succeed_When_AllCategoriesAreRetrieved()
        {
            // arrange
            var data = new List<Category>
            {
                new Category { Name = "Category 1" },
                new Category { Name = "Category 2" },
                new Category { Name = "Category 3" },
            };

            await using var dbInstance = DatabaseMock.Instance;
            var categoryRepository = new EfDeletableEntityRepository<Category>(dbInstance);

            // act
            foreach (var category in data)
            {
                await categoryRepository.AddAsync(category);
            }

            await categoryRepository.SaveChangesAsync();

            var categoriesService = new CategoriesService(categoryRepository);
            AutoMapperConfig.RegisterMappings(typeof(MyTestCategory).Assembly);

            var models = categoriesService.GetAllCategories<MyTestCategory>();

            // assert
            Assert.Equal(3, models.Count());
        }

        public class MyTestCategory : IMapFrom<Category>
        {
            public string Name { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services;
using WeLearn.Services.Mapping;
using WeLearn.Tests.HelperClasses;
using Xunit;

namespace WeLearn.Tests
{
    public class CategoriesServiceTests
    {
        //todo-crit-plus-other-tests: For these tests and others,
        // see how to unit test with repository and rewreite
        public CategoriesServiceTests()
        {
            // this.mapper = AutoMapperConfig.MapperInstance;
            // this.mapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper();
        }

        [Fact]
        public void Should_Succeed_When_AllCategoriesAreRetrieved()
        {
            // arrange 
            var data = new List<Category>
            {
                new Category {Id = 1, Name = "Category1" },
                new Category {Id = 2, Name = "Category2" },
                new Category {Id = 3, Name = "Category3" },
                new Category {Id = 4, Name = "Category4" },
            }.AsQueryable();

            Mock<DbSet<Category>> mockSet = new Mock<DbSet<Category>>();

            mockSet.As<IAsyncEnumerable<Category>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Category>(data.GetEnumerator()));

            mockSet.As<IQueryable<Category>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Category>(data.Provider));

            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Categories).Returns(mockSet.Object);

            // var service = new CategoriesService(mockContext.Object);

            // act
            // var categoriesCount = service.GetAllCategories();

            // assert
            // Assert.Equal(4, categoriesCount.Count());
            Assert.Equal(4, 1);
        }

        [Fact]
        public void Should_Succeed_When_CategoriesCountIsRetrieved()
        {
            // arrange 
            var data = new List<Category>
            {
                new Category {Id = 1, Name = "Category1", CreatedOn = DateTime.Now,},
            }.AsQueryable();

            Mock<DbSet<Category>> mockSet = new Mock<DbSet<Category>>();

            mockSet.As<IAsyncEnumerable<Category>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Category>(data.GetEnumerator()));

            mockSet.As<IQueryable<Category>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Category>(data.Provider));

            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Categories).Returns(mockSet.Object);

            // var service = new CategoriesService(mockContext.Object);

            // act
            // int categoriesCount = service.GetAllCategoriesCount();

            // assert
            // Assert.Equal(1, categoriesCount);
            Assert.Equal(1, 3);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Services;
using WeLearn.ViewModels;
using WeLearn.Web.Controllers;
using WeLearn.Data.Models;
using Xunit;
using AutoMapper;
using WeLearn.Web.Infrastructure;
using WeLearn.Tests.HelperClasses;
using System.Threading;

namespace WeLearn.Tests
{
    public class CategoriesServiceTests
    {
        private IMapper mapper;

        public CategoriesServiceTests()
        {
            this.mapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper();
        }

		[Fact]
		public void Should_Succeed_When_CategoriesAreRetrieved()
		{
			// arrange 
			var data = new List<Category>
			{
				new Category { Id = 1, Name = "Category1", DateCreated = DateTime.Now, },
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

			var service = new CategoriesService(mockContext.Object, mapper);

			// act
			int categoriesCount = service.GetAllCategoriesCount();

			// assert
			Assert.Equal(1, categoriesCount);
		}
	}
}

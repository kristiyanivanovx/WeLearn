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
        public async Task CreatingAndGettingTwoNewCategoriesShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test1");

            // arrange
            using var db = new ApplicationDbContext(dbOptionsBuilder.Options);
            db.Set<Category>().Add(new Category()
            {
                Id = 1,
                Name = "New",
                DateCreated = DateTime.UtcNow
            });
            db.Set<Category>().Add(new Category()
            {
                Id = 2,
                Name = "another",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();
                
            var service = new CategoriesService(db, mapper);

            // act
            var result = service.GetAllCategories();

            // assert
            Assert.Equal(2, result.Count());
        }
    }
}

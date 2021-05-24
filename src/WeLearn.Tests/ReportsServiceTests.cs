using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.ViewModels;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Enums;
using WeLearn.Services;
using WeLearn.Web.Infrastructure;
using Xunit;
using WeLearn.ViewModels.Admin;

namespace WeLearn.Tests
{
    public class ReportsServiceTests
    {
        private IMapper mapper;

        public ReportsServiceTests()
        {
            this.mapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper();
        }

        [Fact]
        public async Task CreatingAndGettingReportShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test8");

            // arrange
            using var db = new ApplicationDbContext(dbOptionsBuilder.Options);

            db.Set<ApplicationUser>().Add(new ApplicationUser()
            {
                Id = "xyz123",
                UserName = "New22",
                PasswordHash = "123"
            });
            db.Set<Material>().Add(new Material()
            {
                Id = 1,
                Name = "m-name",
                Link = "..."
            });
            db.Set<Video>().Add(new Video()
            {
                Id = 2,
                Name = "v-name",
                Link = "..",
                ContentType = "null"
            });
            db.Set<Category>().Add(new Category()
            {
                Id = 3,
                Name = "c-name",
            });
            db.Set<Lesson>().Add(new Lesson()
            {
                Id = 6,
                Name = "No23",
                IsApproved = true,
                Description = "New and fun",
                Grade = Grade.Eighth,
                CategoryId = 3,
                MaterialId = 1,
                VideoId = 2,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            db.Set<Report>().Add(new Report()
            {
                Id = 6,
                Subject = "subject",
                Description = "New and fun",
                LessonId = 6,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();

            var service = new ReportsService(db, mapper);

            // act
            var result = await service.GetReportByIdAsync<AdministrationReportModel>(6);

            // assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CreatingAndGettingMultipleReportsShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test9");

            // arrange
            using var db = new ApplicationDbContext(dbOptionsBuilder.Options);

            db.Set<ApplicationUser>().Add(new ApplicationUser()
            {
                Id = "xyz123",
                UserName = "New22",
                PasswordHash = "123"
            });
            db.Set<Material>().Add(new Material()
            {
                Id = 1,
                Name = "m-name",
                Link = "..."
            });
            db.Set<Video>().Add(new Video()
            {
                Id = 2,
                Name = "v-name",
                Link = "..",
                ContentType = "null"
            });
            db.Set<Category>().Add(new Category()
            {
                Id = 3,
                Name = "c-name",
            });
            db.Set<Lesson>().Add(new Lesson()
            {
                Id = 6,
                Name = "No23",
                IsApproved = true,
                Description = "New and fun",
                Grade = Grade.Eighth,
                CategoryId = 3,
                MaterialId = 1,
                VideoId = 2,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            db.Set<Report>().Add(new Report()
            {
                Id = 6,
                Subject = "subject",
                Description = "New and fun",
                LessonId = 6,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            db.Set<Report>().Add(new Report()
            {
                Id = 7,
                Subject = "subject",
                Description = "New and fun",
                LessonId = 6,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            db.Set<Report>().Add(new Report()
            {
                Id = 8,
                Subject = "subject",
                Description = "New and fun",
                LessonId = 6,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();

            var service = new ReportsService(db, mapper);

            // act
            var result = await service.GetAllReportsAsync(null);

            // assert
            Assert.Equal(3, result.Count());
        }

        [Fact]
        public async Task CreatingAndHardDeletingReportShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test10");

            // arrange
            using var db = new ApplicationDbContext(dbOptionsBuilder.Options);

            db.Set<ApplicationUser>().Add(new ApplicationUser()
            {
                Id = "xyz123",
                UserName = "New22",
                PasswordHash = "123"
            });
            db.Set<Material>().Add(new Material()
            {
                Id = 1,
                Name = "m-name",
                Link = "..."
            });
            db.Set<Video>().Add(new Video()
            {
                Id = 2,
                Name = "v-name",
                Link = "..",
                ContentType = "null"
            });
            db.Set<Category>().Add(new Category()
            {
                Id = 3,
                Name = "c-name",
            });
            db.Set<Lesson>().Add(new Lesson()
            {
                Id = 6,
                Name = "No23",
                IsApproved = true,
                Description = "New and fun",
                Grade = Grade.Eighth,
                CategoryId = 3,
                MaterialId = 1,
                VideoId = 2,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            db.Set<Report>().Add(new Report()
            {
                Id = 6,
                Subject = "subject",
                Description = "New and fun",
                LessonId = 6,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();

            var service = new ReportsService(db, mapper);
            
            // act
            await service.HardDeleteReportByIdAsync(6);

            var reports = await service.GetAllReportsAsync(null);

            // assert
            Assert.Empty(reports);
        }
    }
}

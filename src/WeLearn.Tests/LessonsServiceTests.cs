using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services;
using WeLearn.ViewModels;
using WeLearn.Web.Infrastructure;
using WeLearn.Data.Models.Enums;
using Xunit;
using WeLearn.ViewModels.Admin;
using WeLearn.ViewModels.Admin.Lesson;

namespace WeLearn.Tests
{
    public class LessonsServiceTests
    {
        private readonly IMapper mapper;

        public LessonsServiceTests()
        {
            this.mapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper();
        }

        [Fact]
        public async Task SoftDeletingLessonShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test5");

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
                Description = "New and fun",
                Grade = Grade.Eighth,
                CategoryId = 3,
                MaterialId = 1,
                VideoId = 2,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();

            var inputOutputService = new InputOutputService();
            var lessonsService = new LessonsService(db, mapper, inputOutputService);

            // act
            await lessonsService.SoftDeleteLessonByIdAsync(6);
            var comment = await lessonsService.GetLessonByIdAdministrationAsync<AdminLessonViewModel>(6);

            // assert
            Assert.Equal(6, comment.Id);
            Assert.False(comment.IsApproved);
            Assert.True(comment.IsDeleted);
        }

        [Fact]
        public async Task GettingByCategoryShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test6");

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
            await db.SaveChangesAsync();

            var inputOutputService = new InputOutputService();
            var lessonsService = new LessonsService(db, mapper, inputOutputService);

            // act
            var comments = await lessonsService.GetAllLessonsByCategoryAsync("c-name", null);

            // assert
            Assert.Single(comments);
        }

        [Fact]
        public async Task HardDeletingLessonShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test7");

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
                Description = "New and fun",
                Grade = Grade.Eighth,
                CategoryId = 3,
                MaterialId = 1,
                VideoId = 2,
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();

            var archiveService = new InputOutputService();
            var lessonsService = new LessonsService(db, mapper, archiveService);

            // act
            await lessonsService.HardDeleteLessonByIdAsync(6);
            var comment = await lessonsService.GetLessonByIdAdministrationAsync<AdminLessonViewModel>(6);

            // assert
            Assert.Null(comment);
        }
    }
}

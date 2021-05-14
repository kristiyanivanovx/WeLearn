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
    public class CommentsServiceTests
    {
        private IMapper mapper;

        public CommentsServiceTests()
        {
            this.mapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper();
        }

        [Fact]
        public async Task CreatingAndGettingOneNewCommentShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test2");

            // arrange
            using var db = new ApplicationDbContext(dbOptionsBuilder.Options);

            db.Set<ApplicationUser>().Add(new ApplicationUser()
            {
                Id = "322s",
                UserName = "New",
                PasswordHash = "123"
            });
            db.Set<Comment>().Add(new Comment()
            {
                Id = 1,
                Content = "New",
                ApplicationUserId = "322s",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();
                
            var service = new CommentsService(db, mapper);

            // act
            var result = await service.GetAllCommentsAsync();

            // assert
            Assert.Single(result);
        }

        [Fact]
        public async Task HardDeletingCommentShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test3");

            // arrange
            using var db = new ApplicationDbContext(dbOptionsBuilder.Options);

            db.Set<ApplicationUser>().Add(new ApplicationUser()
            {
                Id = "2",
                UserName = "New",
                PasswordHash = "123"
            });
            db.Set<Comment>().Add(new Comment()
            {
                Id = 2,
                Content = "New",
                ApplicationUserId = "2",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();

            var service = new CommentsService(db, mapper);

            // act
            await service.HardDeleteCommentByIdAsync(2);
            var comments = await service.GetAllCommentsAsync();

            // assert
            Assert.Empty(comments);
        }

        [Fact]
        public async Task SoftDeletingCommentShouldWorkAsExpected()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("Test4");

            // arrange
            using var db = new ApplicationDbContext(dbOptionsBuilder.Options);

            db.Set<ApplicationUser>().Add(new ApplicationUser()
            {
                Id = "xyz",
                UserName = "New22",
                PasswordHash = "123"
            });
            db.Set<Comment>().Add(new Comment()
            {
                Id = 3,
                Content = "New",
                ApplicationUserId = "xyz",
                DateCreated = DateTime.UtcNow
            });
            await db.SaveChangesAsync();

            var service = new CommentsService(db, mapper);

            // act
            await service.SoftDeleteCommentByIdAsync(3);
            var comments = await service.GetAllCommentsAsync();

            // assert
            Assert.True(comments.FirstOrDefault().IsDeleted);
        }
    }
}

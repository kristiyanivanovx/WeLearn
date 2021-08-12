using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services;
using WeLearn.Web.Infrastructure;
using Xunit;
using Moq;
using WeLearn.Tests.HelperClasses;
using System.Threading;
using WeLearn.ViewModels.Lesson;

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
        public async Task Should_Succeed_When_LessonIsSoftDeleted()
        {
            // arrange 
            var data = new List<Lesson>
            {
                new Lesson { Id = 1, Name = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd" },
                new Lesson { Id = 2, Name = "Cdsa2", Description = "1233", DateCreated = DateTime.Now, ApplicationUserId = "as4d" },
            }.AsQueryable();

            Mock<DbSet<Lesson>> mockSet = new Mock<DbSet<Lesson>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Lesson>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Lesson>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Lesson>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Lessons).Returns(mockSet.Object);

            var inputOutputService = new InputOutputService();
            var service = new LessonsService(mockContext.Object, mapper, inputOutputService);

            // act
            await service.SoftDeleteLessonByIdAsync(1);

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Once());
        }

        [Fact]
        public async Task Should_Succeed_When_AllLessonsAreRetrieved()
        {
            // arrange 
            var data = new List<Lesson>
            {
                new Lesson { Id = 1, Name = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", IsApproved = true },
                new Lesson { Id = 2, Name = "Cdsa2", Description = "1233", DateCreated = DateTime.Now, ApplicationUserId = "as4d", IsApproved = true },
            }.AsQueryable();

            Mock<DbSet<Lesson>> mockSet = new Mock<DbSet<Lesson>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Lesson>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Lesson>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Lesson>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Lessons).Returns(mockSet.Object);

            var inputOutputService = new InputOutputService();
            var service = new LessonsService(mockContext.Object, mapper, inputOutputService);

            // act
            var models = await service.GetAllLessonsAsync<LessonViewModel>(null);

            // assert
            Assert.Equal(2, models.Count());
        }

        [Fact]
        public async Task Should_Succeed_When_LessonsAreRetrievedByUser()
        {
            var userId = "asd";

            // arrange 
            var data = new List<Lesson>
            {
                new Lesson { Id = 1, Name = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = userId, IsApproved = true },
                new Lesson { Id = 2, Name = "Cdsa2", Description = "1233", DateCreated = DateTime.Now, ApplicationUserId = "as4d", IsApproved = true },
            }.AsQueryable();

            Mock<DbSet<Lesson>> mockSet = new Mock<DbSet<Lesson>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Lesson>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Lesson>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Lesson>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Lessons).Returns(mockSet.Object);

            var inputOutputService = new InputOutputService();
            var service = new LessonsService(mockContext.Object, mapper, inputOutputService);

            // act
            var models = await service.GetCreatedByMeAsync(userId, null);

            // assert
            Assert.Single(models);
        }
    }
}

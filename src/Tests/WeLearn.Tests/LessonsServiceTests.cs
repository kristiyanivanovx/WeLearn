using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Repositories;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using WeLearn.Tests.HelperClasses;
using WeLearn.Web.ViewModels.Lesson;
using Xunit;

namespace WeLearn.Tests
{
    public class LessonsServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_LessonIsSoftDeleted()
        {
            // arrange
            var data = new List<Lesson>
            {
                new Lesson {Id = 1, Name = "asd", Description = "123", ApplicationUserId = "asd"},
                new Lesson {Id = 2, Name = "asd", Description = "1233", ApplicationUserId = "as4d"},
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

            // var service = new LessonsService(mockContext.Object, inputOutputService);
            //
            // // act
            // await service.SoftDeleteLessonByIdAsync(1);
            //
            // // assert
            // mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Once());
        }

        [Fact]
        public async Task Should_Succeed_When_AllLessonsAreRetrieved()
        {
            // arrange
            var data = new List<Lesson>
            {
                new Lesson
                {
                    Id = 1, Name = "Test Content", Description = "123", ApplicationUserId = "asd", IsApproved = true
                },
                new Lesson
                {
                    Id = 2, Name = "Test Content2", Description = "1233", ApplicationUserId = "as4d", IsApproved = true
                },
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

            var mockedVideoRepo = new Mock<IDeletableEntityRepository<Video>>();
            var mockedMaterialRepo = new Mock<IDeletableEntityRepository<Material>>();
            var mockedLessonRepo = new Mock<IDeletableEntityRepository<Lesson>>();
            var mockedInputOutputService = new Mock<IInputOutputService>();

            var service = new LessonsService(
                mockedVideoRepo.Object,
                mockedMaterialRepo.Object,
                mockedLessonRepo.Object,
                mockedInputOutputService.Object);

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
                new Lesson {Id = 1, Name = "asd", Description = "123", ApplicationUserId = userId, IsApproved = true},
                new Lesson {Id = 2, Name = "asd", Description = "1233", ApplicationUserId = "as4d", IsApproved = true},
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

            var mockedVideoRepo = new Mock<IDeletableEntityRepository<Video>>();
            var mockedMaterialRepo = new Mock<IDeletableEntityRepository<Material>>();
            var mockedLessonRepo = new Mock<IDeletableEntityRepository<Lesson>>();
            var mockedInputOutputService = new Mock<IInputOutputService>();

            var service = new LessonsService(
                mockedVideoRepo.Object,
                mockedMaterialRepo.Object,
                mockedLessonRepo.Object,
                mockedInputOutputService.Object);

            // act
            var models = await service.GetCreatedByMeAsync(userId, null);

            // assert
            Assert.Single(models);
        }
    }
}

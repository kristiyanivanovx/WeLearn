using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services;
using WeLearn.Services.Mapping;
using WeLearn.Tests.HelperClasses;
using WeLearn.Web.ViewModels.Admin.Report;
using WeLearn.Web.ViewModels.Report.Comment;
using WeLearn.Web.ViewModels.Report.Lesson;
using Xunit;

namespace WeLearn.Tests
{
    public class ReportsServiceTests
    {
        public ReportsServiceTests()
        {
            // this.mapper = AutoMapperConfig.MapperInstance;
            // this.mapper = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper();
        }

        [Fact]
        public async Task Should_Succeed_When_ReportIsCreated()
        {
            // arrange
            var data = new List<Report>
            {
                new Report
                {
                    Id = 1, Subject = "123", Description = "123", ApplicationUserId = "asd", LessonId = 3
                },
            }.AsQueryable();

            Mock<DbSet<Report>> mockSet = new Mock<DbSet<Report>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Report>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Report>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Report>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Reports).Returns(mockSet.Object);

            var service = new ReportsService(mockContext.Object);

            // act
            var model = new LessonReportInputModel()
            {
                Subject = "123",
                ReportDescription = "123",
                ApplicationUserId = "asd",
                LessonId = 3
            };
            await service.CreateReportAsync(model);

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }

        [Fact]
        public async Task Should_Succeed_When_LessonReportIsEdited()
        {
            // arrange 
            var data = new List<Report>
            {
                new Report
                {
                    Id = 1, Subject = "asd",
                    Description = "123", 
                    ApplicationUserId = "asd",
                    LessonId = 3
                },
            }.AsQueryable();

            Mock<DbSet<Report>> mockSet = new Mock<DbSet<Report>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Report>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Report>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Report>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Reports).Returns(mockSet.Object);

            var service = new ReportsService(mockContext.Object);

            // act
            var model = new LessonReportEditModel()
            {
                ReportId = 1,
                Subject = "dsa",
                ReportDescription = "123",
                ApplicationUserId = "asd",
                LessonId = 3
            };
            await service.EditLessonReportAsync(model);

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }

        [Fact]
        public async Task Should_Succeed_When_CommentReportIsEdited()
        {
            // arrange
            var data = new List<Report>
            {
                new Report
                {
                    Id = 1, Subject = "dsa", Description = "123", ApplicationUserId = "asd",
                    LessonId = 3
                },
            }.AsQueryable();

            Mock<DbSet<Report>> mockSet = new Mock<DbSet<Report>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Report>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Report>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Report>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Reports).Returns(mockSet.Object);

            var service = new ReportsService(mockContext.Object);

            // act
            var model = new CommentReportEditModel()
            {
                ReportId = 1,
                Subject = "dsa",
                ReportDescription = "123",
                ApplicationUserId = "asd"
            };
            await service.EditCommentReportAsync(model);

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }

        [Fact]
        public async Task Should_Succeed_When_ReportIsEditedByAdmin()
        {
            // arrange 
            var data = new List<Report>
            {
                new Report
                {
                    Id = 1,
                    Subject = "dsa",
                    Description = "123",
                    ApplicationUserId = "asd",
                    LessonId = 3
                },
            }.AsQueryable();

            Mock<DbSet<Report>> mockSet = new Mock<DbSet<Report>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Report>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Report>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Report>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Reports).Returns(mockSet.Object);

            var service = new ReportsService(mockContext.Object);

            // act
            var model = new AdminReportEditModel()
                {
                    Id = 1,
                    Subject = "das",
                    Description = "1223",
                    ApplicationUserId = "1asd"
                };
            await service.EditReportAdministrationAsync(model);

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }

        [Fact]
        public async Task Should_Succeed_When_ReportIsSoftDeletedById()
        {
            // arrange
            var data = new List<Report>
            {
                new Report
                {
                    Id = 1, 
                    Subject = "dsa", 
                    Description = "123",
                    ApplicationUserId = "asd",
                    LessonId = 3
                },
            }.AsQueryable();

            Mock<DbSet<Report>> mockSet = new Mock<DbSet<Report>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Report>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Report>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Report>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Reports).Returns(mockSet.Object);

            var service = new ReportsService(mockContext.Object);

            // act
            await service.SoftDeleteReportByIdAsync(1);

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }

        [Fact]
        public async Task Should_Succeed_When_ReportIsHardDeletedById()
        {
            // arrange 
            var data = new List<Report>
            {
                new Report
                {
                    Id = 1,
                    Subject = "dsa",
                    Description = "123",
                    ApplicationUserId = "asd",
                    LessonId = 3
                },
            }.AsQueryable();

            Mock<DbSet<Report>> mockSet = new Mock<DbSet<Report>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Report>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Report>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Report>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Reports).Returns(mockSet.Object);

            var service = new ReportsService(mockContext.Object);

            // act
            await service.HardDeleteReportByIdAsync(1);

            // assert
            mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }

        [Fact]
        public async Task Should_Succeed_When_AllReportsAreRetrieved()
        {
            // arrange 
            var data = new List<Report>
            {
                new Report
                {
                    Id = 1,
                    Subject = "asd",
                    Description = "123",
                    ApplicationUserId = "asd",
                    LessonId = 3
                },
                new Report
                {
                    Id = 2, Subject = "asd",
                    Description = "1233",
                    ApplicationUserId = "as4d",
                    LessonId = 3
                },
            }.AsQueryable();

            Mock<DbSet<Report>> mockSet = new Mock<DbSet<Report>>();

            mockSet.As<IAsyncEnumerable<Report>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Report>(data.GetEnumerator()));

            mockSet.As<IQueryable<Report>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Report>(data.Provider));

            mockSet.As<IQueryable<Report>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Report>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Report>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Reports).Returns(mockSet.Object);

            var service = new ReportsService(mockContext.Object);

            // act
            var reports = await service.GetAllReportsAsync<CommentReportViewModel>(null);

            // assert
            Assert.Equal(2, reports.Count());
        }
    }
}

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
using WeLearn.ViewModels.Report.Lesson;
using WeLearn.ViewModels.Admin.Report;
using Moq;
using WeLearn.Tests.HelperClasses;
using System.Threading;
using WeLearn.ViewModels.Report.Comment;

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
        public async Task Should_Succeed_When_ReportIsCreated()
        {
            // arrange 
            var data = new List<Report>
            {
                new Report { Id = 1, Subject = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 },
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

            var service = new ReportsService(mockContext.Object, mapper);

            // act
            var model = new LessonReportInputModel() { Subject = "Cdsa", ReportDescription = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 };
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
                new Report { Id = 1, Subject = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 },
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

            var service = new ReportsService(mockContext.Object, mapper);

            // act
            var model = new LessonReportEditModel() { ReportId = 1, Subject = "Cdsa", ReportDescription = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 };
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
                new Report { Id = 1, Subject = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 },
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

            var service = new ReportsService(mockContext.Object, mapper);

            // act
            var model = new CommentReportEditModel() { ReportId = 1, Subject = "Cdsa", ReportDescription = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd" };
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
                new Report { Id = 1, Subject = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 },
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

            var service = new ReportsService(mockContext.Object, mapper);

            // act
            var model = new AdminReportEditModel() { Id = 1, Subject = "Cdsa66", Description = "1223", DateCreated = DateTime.Now, ApplicationUserId = "1asd" };
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
                new Report { Id = 1, Subject = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 },
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

            var service = new ReportsService(mockContext.Object, mapper);

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
                new Report { Id = 1, Subject = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 },
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

            var service = new ReportsService(mockContext.Object, mapper);

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
                new Report { Id = 1, Subject = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = "asd", LessonId = 3 },
                new Report { Id = 2, Subject = "Cdsa2", Description = "1233", DateCreated = DateTime.Now, ApplicationUserId = "as4d", LessonId = 3 },
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

            var service = new ReportsService(mockContext.Object, mapper);

            // act
            var reports = await service.GetAllReportsAsync<CommentReportViewModel>(null);

            // assert
            Assert.Equal(2, reports.Count());
        }

        //  Message: 
        //    System.ArgumentException : Argument expression is not valid
        [Fact]
        public async Task Should_Succeed_When_ReportByIdIsRetrieved()
        {
            string userId = "asd";

            // arrange 
            var data = new List<Report>
            {
                new Report { Id = 1, Subject = "Cdsa", Description = "123", DateCreated = DateTime.Now, ApplicationUserId = userId, CommentId = 3, IsDeleted = false, },
                new Report { Id = 2, Subject = "Cdsa2", Description = "1233", DateCreated = DateTime.Now, ApplicationUserId = userId, CommentId = 3, IsDeleted = false },
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

            var service = new ReportsService(mockContext.Object, mapper);

            // act
            CommentReportViewModel report = await service.GetReportByIdAsync<CommentReportViewModel>(1);

            // assert
            Assert.NotNull(report);
            mockContext.Verify(x => x.Reports.FirstOrDefaultAsync(new CancellationToken()), Times.Once());
        }
    }
}

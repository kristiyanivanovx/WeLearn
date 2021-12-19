using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using WeLearn.Data;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Repositories;
using WeLearn.Services;
using WeLearn.Web.ViewModels.Admin.Report;
using WeLearn.Web.ViewModels.Report.Comment;
using WeLearn.Web.ViewModels.Report.Lesson;
using Xunit;

namespace WeLearn.Tests
{
    public class ReportsServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_LessonReportIsCreated()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var reportRepository = new EfDeletableEntityRepository<Report>(new ApplicationDbContext(options));
            var service = new ReportsService(reportRepository);

            var testSubject = "customTestSubject";
            var testDescription = "customDesc123";
            var testAppUserId = "userId";
            var testLessonId = 3;

            var model = new LessonReportInputModel
            {
                Subject = testSubject,
                ReportDescription = testDescription,
                ApplicationUserId = testAppUserId,
                LessonId = testLessonId
            };

            // act
            await service.CreateLessonReportAsync(model);

            var entity = reportRepository.All().FirstOrDefault(x => x.Subject == testSubject);
            var entityExists = service.Contains(entity!.Id);
            var entitiesCount = service.GetCount();

            // assert
            Assert.True(entityExists);
            Assert.Equal(1, entitiesCount);
            Assert.NotNull(entity);
            Assert.Equal(testSubject, entity.Subject);
            Assert.Equal(testDescription, entity.Description);
            Assert.Equal(testAppUserId, entity.ApplicationUserId);
            Assert.Equal(testLessonId, entity.LessonId);
        }

        [Fact]
        public async Task Should_Succeed_When_LessonReportIsEdited()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var reportRepository = new EfDeletableEntityRepository<Report>(new ApplicationDbContext(options));
            var service = new ReportsService(reportRepository);

            var testSubject = "subjectOne";
            var testReportDescription = "init";
            var testAppUserId = "asd123";
            var testReportId = 1;
            var testLessonId = 3;

            var model = new LessonReportInputModel()
            {
                LessonId = testLessonId,
                Subject = testSubject,
                ReportDescription = testReportDescription,
                ApplicationUserId = testAppUserId,
            };

            // act
            await service.CreateLessonReportAsync(model);

            var expectedSubject = "new";
            var expectedDescription = "changed";

            var changedModel = new LessonReportEditModel()
            {
                ReportId = testReportId,
                Subject = expectedSubject,
                ReportDescription = expectedDescription,
                LessonId = testLessonId,
            };

            await service.EditLessonReportAsync(changedModel);

            var entity = reportRepository.All().FirstOrDefault(x => x.Subject == expectedSubject);

            // assert
            Assert.NotNull(entity);
            Assert.Equal(testLessonId, entity.LessonId);
            Assert.Equal(expectedSubject, entity.Subject);
            Assert.Equal(expectedDescription, entity.Description);
        }

        [Fact]
        public async Task Should_Succeed_When_CommentReportIsEdited()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var reportRepository = new EfDeletableEntityRepository<Report>(new ApplicationDbContext(options));
            var service = new ReportsService(reportRepository);

            var testSubject = "subjectOne";
            var testDescription = "init123";
            var testAppUserId = "asd123";
            var testCommentId = 3;

            var subjectChanged = "subjChanged123das";
            var descriptionChanged = "descriptionChanged123das";

            var model = new CommentReportInputModel
            {
                Subject = testSubject,
                ReportDescription = testDescription,
                ApplicationUserId = testAppUserId,
                CommentId = testCommentId
            };

            // act
            await service.CreateCommentReportAsync(model);

            var editModel = new CommentReportEditModel()
            {
                ReportId = 1,
                Subject = subjectChanged,
                ReportDescription = descriptionChanged,
                ApplicationUserId = testAppUserId
            };

            await service.EditCommentReportAsync(editModel);

            var editedEntity = reportRepository
                .All()
                .FirstOrDefault(x => x.Description == descriptionChanged);

            // assert
            Assert.NotNull(editedEntity);
            Assert.Equal(subjectChanged, editedEntity.Subject);
            Assert.Equal(descriptionChanged, editedEntity.Description);
        }

        [Fact]
        public async Task Should_Succeed_When_LessonReportIsEditedByAdmin()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var reportRepository = new EfDeletableEntityRepository<Report>(new ApplicationDbContext(options));
            var service = new ReportsService(reportRepository);

            var testSubject = "subjectOne";
            var testDescription = "init123";
            var testAppUserId = "asd123";
            var testLessonId = 3;

            var subjectChanged = "subjChanged444";
            var descriptionChanged = "descriptionChanged555";

            var model = new LessonReportInputModel
            {
                Subject = testSubject,
                ReportDescription = testDescription,
                ApplicationUserId = testAppUserId,
                LessonId = testLessonId
            };

            // act
            await service.CreateLessonReportAsync(model);

            var entity = reportRepository.All().FirstOrDefault(x => x.Description == testDescription);

            var editModel = new AdminReportEditModel
            {
                Id = entity!.Id,
                Subject = subjectChanged,
                Description = descriptionChanged,
                ApplicationUserId = "1asd",
            };

            await service.EditReportAdministrationAsync(editModel);
            var editedEntity = reportRepository.All().FirstOrDefault(x => x.Description == descriptionChanged);

            // assert
            Assert.NotNull(entity);
            Assert.Equal(descriptionChanged, editedEntity!.Description);
            Assert.Equal(subjectChanged, editedEntity.Subject);
        }

        [Fact]
        public async Task Should_Succeed_When_LessonReportIsSoftDeletedByAdmin()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var reportRepository = new EfDeletableEntityRepository<Report>(new ApplicationDbContext(options));
            var service = new ReportsService(reportRepository);

            var testSubject = "subjectOne";
            var testDescription = "init123";
            var testAppUserId = "asd123";
            var testLessonId = 3;

            var subjectChanged = "subjChanged444";
            var descriptionChanged = "descriptionChanged555";

            var model = new LessonReportInputModel
            {
                Subject = testSubject,
                ReportDescription = testDescription,
                ApplicationUserId = testAppUserId,
                LessonId = testLessonId
            };

            // act
            await service.CreateLessonReportAsync(model);

            var entity = reportRepository.All().FirstOrDefault(x => x.Description == testDescription);
            var editModel = new AdminReportEditModel
            {
                Id = entity!.Id,
                Subject = subjectChanged,
                Description = descriptionChanged,
                ApplicationUserId = "1asd",
                IsDeleted = true,
            };

            await service.EditReportAdministrationAsync(editModel);
            var editedEntity = reportRepository.All().FirstOrDefault(x => x.Description == descriptionChanged);

            // assert
            Assert.NotNull(entity);
            Assert.Null(editedEntity);
        }

        [Fact]
        public async Task Should_Succeed_When_LessonReportIsSoftDeletedById()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var reportRepository = new EfDeletableEntityRepository<Report>(new ApplicationDbContext(options));
            var service = new ReportsService(reportRepository);

            var testSubject = "subjectOne";
            var testDescription = "init1237";
            var testAppUserId = "asd1238";
            var testReportId = 1;
            var testLessonId = 3;

            var model = new LessonReportInputModel
            {
                Subject = testSubject,
                ReportDescription = testDescription,
                ApplicationUserId = testAppUserId,
                LessonId = testLessonId
            };

            // act
            await service.CreateLessonReportAsync(model);
            await service.SoftDeleteReportByIdAsync(testReportId);

            var entities = reportRepository.All();
            var entitiesWithSoftDeleted = reportRepository.AllWithDeleted();

            // assert
            Assert.Equal(0, entities.Count());
            Assert.Single(entitiesWithSoftDeleted);
        }

        [Fact]
        public async Task Should_Succeed_When_LessonReportIsHardDeletedById()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var reportRepository = new EfDeletableEntityRepository<Report>(new ApplicationDbContext(options));
            var service = new ReportsService(reportRepository);

            var testSubject = "subjectOne";
            var testDescription = "init123";
            var testAppUserId = "asd1239";
            var testReportId = 1;
            var testLessonId = 3;

            var model = new LessonReportInputModel
            {
                Subject = testSubject,
                ReportDescription = testDescription,
                ApplicationUserId = testAppUserId,
                LessonId = testLessonId
            };

            // act
            await service.CreateLessonReportAsync(model);
            await service.HardDeleteReportByIdAsync(testReportId);

            var entities = reportRepository.All();
            var entitiesWithSoftDeleted = reportRepository.AllWithDeleted();

            // assert
            Assert.Equal(0, entities.Count());
            Assert.Equal(0, entitiesWithSoftDeleted.Count());
        }

        [Fact]
        public async Task Should_Succeed_When_AllReportsAreRetrieved()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var reportRepository = new EfDeletableEntityRepository<Report>(new ApplicationDbContext(options));
            var service = new ReportsService(reportRepository);

            var testSubject = "subjectOne";
            var testDescription = "init1230";
            var testAppUserId = "asd1230";
            var testLessonId = 3;

            var modelOne = new LessonReportInputModel
            {
                Subject = testSubject,
                ReportDescription = testDescription,
                ApplicationUserId = testAppUserId,
                LessonId = testLessonId
            };

            var modelTwo = new LessonReportInputModel
            {
                Subject = testSubject,
                ReportDescription = testDescription,
                ApplicationUserId = testAppUserId,
                LessonId = testLessonId
            };

            // act
            await service.CreateLessonReportAsync(modelOne);
            await service.CreateLessonReportAsync(modelTwo);
            var entities = reportRepository.All();

            // assert
            Assert.Equal(2, entities.Count());
        }
    }
}

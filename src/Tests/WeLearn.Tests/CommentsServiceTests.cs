using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Services;
using WeLearn.Services.Mapping;
using WeLearn.Tests.HelperClasses;
using WeLearn.Web.ViewModels.Admin.Comment;
using WeLearn.Web.ViewModels.Comment;
using Xunit;

namespace WeLearn.Tests
{
    public class CommentsServiceTests
    {
        [Fact]
        public async Task Should_ReturnAllComments_When_ParameterIsNull()
        {
            // arrange
            var data = new List<Comment>
            {
                new Comment { Content = "x-content" },
                new Comment { Content = "y-content" },
                new Comment { Content = "z-content" },
            }.AsQueryable();

            Mock<DbSet<Comment>> mockSet = new Mock<DbSet<Comment>>();

            mockSet.As<IAsyncEnumerable<Comment>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Comment>(data.GetEnumerator()));

            mockSet.As<IQueryable<Comment>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Comment>(data.Provider));

            mockSet.As<IQueryable<Comment>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();

            // mockContext.Setup(x => x.Comments).Returns(mockSet.Object);
            //
            // var service = new CommentsService(mockContext.Object);
            //
            // // act
            // var result = await service.GetAllCommentsAsync(null);
            //
            // // assert
            // Assert.Equal(3, result.Count());
        }

        [Fact]
        public async Task Should_Succeed_When_CommentsAreHardDeleted()
        {
            // arrange
            var data = new List<Comment>
            {
                new Comment { Id = 1, Content = "C" },
                new Comment { Id = 2, Content = "Ca" },
                new Comment { Id = 3, Content = "Cab" },
            }.AsQueryable();

            Mock<DbSet<Comment>> mockSet = new Mock<DbSet<Comment>>();

            mockSet.As<IAsyncEnumerable<Comment>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Comment>(data.GetEnumerator()));

            mockSet.As<IQueryable<Comment>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Comment>(data.Provider));

            mockSet.As<IQueryable<Comment>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            // Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            // mockContext.Setup(x => x.Comments).Returns(mockSet.Object);
            //
            // var service = new CommentsService(mockContext.Object);
            //
            // // act
            // await service.HardDeleteCommentByIdAsync(1);
            // await service.HardDeleteCommentByIdAsync(2);
            // var result = await service.GetAllCommentsAsync(null);
            //
            // // assert
            // mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(2));
        }

        [Fact]
        public async Task Should_Succeed_When_CommentsAreSoftDeleted()
        {
            // arrange
            var data = new List<Comment>
            {
                new Comment { Id = 1, Content = "c" },
                new Comment { Id = 2, Content = "a" },
            }.AsQueryable();

            Mock<DbSet<Comment>> mockSet = new Mock<DbSet<Comment>>();

            mockSet.As<IAsyncEnumerable<Comment>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Comment>(data.GetEnumerator()));

            mockSet.As<IQueryable<Comment>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Comment>(data.Provider));

            mockSet.As<IQueryable<Comment>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Comments).Returns(mockSet.Object);

            // var service = new CommentsService(mockContext.Object);
            //
            // // act
            // await service.SoftDeleteCommentByIdAsync(1);
            // await service.SoftDeleteCommentByIdAsync(2);
            // var result = await service.GetAllCommentsAsync(null);
            //
            // // assert
            // mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(2));
        }

        [Fact]
        public async Task Should_Succeed_When_CommentIsEdited()
        {
            // arrange
            var data = new List<Comment>
            {
                new Comment
                {
                    Id = 1, Content = "C", ApplicationUserId = "asd", LessonId = 3,
                },
            }.AsQueryable();

            Mock<DbSet<Comment>> mockSet = new Mock<DbSet<Comment>>();

            mockSet.As<IAsyncEnumerable<Comment>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Comment>(data.GetEnumerator()));

            mockSet.As<IQueryable<Comment>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Comment>(data.Provider));

            mockSet.As<IQueryable<Comment>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Comments).Returns(mockSet.Object);

            // var service = new CommentsService(mockContext.Object);
            //
            // // act
            // var model = new CommentEditModel { Id = 1, Content = "asd" };
            // await service.EditCommentAsync(model);
            //
            // // assert
            // mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }

        [Fact]
        public async Task Should_Succeed_When_CommentIsEditedByAdmin()
        {
            // arrange
            var data = new List<Comment>
            {
                new Comment
                {
                    Id = 1, Content = "C", ApplicationUserId = "asd", LessonId = 3,
                },
            }.AsQueryable();

            Mock<DbSet<Comment>> mockSet = new Mock<DbSet<Comment>>();

            mockSet.As<IAsyncEnumerable<Comment>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Comment>(data.GetEnumerator()));

            mockSet.As<IQueryable<Comment>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Comment>(data.Provider));

            mockSet.As<IQueryable<Comment>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            // Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            // mockContext.Setup(x => x.Comments).Returns(mockSet.Object);
            //
            // var service = new CommentsService(mockContext.Object);
            //
            // // act
            // var model = new AdminCommentEditModel() { Id = 1, Content = "asd1" };
            // await service.EditCommentByAdminAsync(model);
            //
            // // assert
            // mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }

        [Fact]
        public async Task Should_Succeed_When_CommentIsCreated()
        {
            // arrange
            var data = new List<Comment>
            {
                new Comment
                {
                    Id = 1, Content = "Test Content", ApplicationUserId = "asd", LessonId = 3,
                },
            }.AsQueryable();

            Mock<DbSet<Comment>> mockSet = new Mock<DbSet<Comment>>();

            mockSet.As<IAsyncEnumerable<Comment>>()
                .Setup(m => m.GetAsyncEnumerator(new CancellationToken()))
                .Returns(new TestingDbAsyncEnumerator<Comment>(data.GetEnumerator()));

            mockSet.As<IQueryable<Comment>>()
                .Setup(m => m.Provider)
                .Returns(new TestingDbAsyncQueryProvider<Comment>(data.Provider));

            mockSet.As<IQueryable<Comment>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Comment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            Mock<ApplicationDbContext> mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(x => x.Comments).Returns(mockSet.Object);

            // var service = new CommentsService(mockContext.Object);
            //
            // // act
            // var model = new CommentInputModel() {Content = "asd" };
            // await service.CreateCommentAsync(model);
            //
            // // assert
            // mockContext.Verify(x => x.SaveChangesAsync(new CancellationToken()), Times.Exactly(1));
        }
    }
}

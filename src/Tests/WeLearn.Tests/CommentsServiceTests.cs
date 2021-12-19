using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Repositories;
using WeLearn.Services;

using WeLearn.Web.ViewModels.Admin.Comment;
using WeLearn.Web.ViewModels.Comment;
using Xunit;

namespace WeLearn.Tests
{
    public class CommentsServiceTests
    {
        [Fact]
        public async Task Should_ReturnAllCommentsCount_When_Valid()
        {
            // arrange
            var data = new List<Comment>
            {
                new Comment { Content = "x-Category" },
                new Comment { Content = "y-Category" },
                new Comment { Content = "z-Category" },
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var commentRepository = new EfDeletableEntityRepository<Comment>(new ApplicationDbContext(options));
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    ApplicationUserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel);
                await commentRepository.SaveChangesAsync();
            }

            // act
            int commentsCount = commentsService.GetAllCommentsCount();

            // assert
            Assert.Equal(3, commentsCount);
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
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var commentRepository = new EfDeletableEntityRepository<Comment>(new ApplicationDbContext(options));
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    ApplicationUserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel);
                await commentRepository.SaveChangesAsync();
            }

            // act
            await commentsService.HardDeleteCommentByIdAsync(1);
            await commentsService.HardDeleteCommentByIdAsync(2);
            var commentsCount = commentsService.GetAllCommentsCount();

            // assert
            Assert.Equal(1, commentsCount);
        }

        [Fact]
        public async Task Should_Succeed_When_CommentsAreSoftDeleted()
        {
            // arrange
            var data = new List<Comment>
            {
                new Comment { Id = 1, Content = "C" },
                new Comment { Id = 2, Content = "Ca" },
                new Comment { Id = 3, Content = "Cab" },
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var commentRepository = new EfDeletableEntityRepository<Comment>(new ApplicationDbContext(options));
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    ApplicationUserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel);
                await commentRepository.SaveChangesAsync();
            }

            var commentId = commentRepository.All().First(x => x.Content == "Cab").Id;

            // act
            await commentsService.SoftDeleteCommentByIdAsync(1);
            await commentsService.SoftDeleteCommentByIdAsync(2);
            var commentsCount = commentsService.GetAllCommentsCount();
            var commentFromDbExists = commentsService.Contains(commentId);

            // assert
            Assert.Equal(1, commentsCount);
            Assert.True(commentFromDbExists);
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
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var commentRepository = new EfDeletableEntityRepository<Comment>(new ApplicationDbContext(options));
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    ApplicationUserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel);
                await commentRepository.SaveChangesAsync();
            }

            // act
            var model = new CommentEditModel { Id = 1, Content = "redacted" };
            await commentsService.EditCommentAsync(model);
            var editedComment = commentRepository.All().First(x => x.Content == "redacted");

            // assert
            Assert.NotNull(editedComment);
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

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var commentRepository = new EfDeletableEntityRepository<Comment>(new ApplicationDbContext(options));
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    ApplicationUserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel);
                await commentRepository.SaveChangesAsync();
            }

            // act
            var model = new AdminCommentEditModel { Id = 1, Content = "redacted-by-admin" };
            await commentsService.EditCommentByAdminAsync(model);
            var editedComment = commentRepository.All().First(x => x.Content == "redacted-by-admin");

            // assert
            Assert.NotNull(editedComment);
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
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var commentRepository = new EfDeletableEntityRepository<Comment>(new ApplicationDbContext(options));
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    ApplicationUserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel);
                await commentRepository.SaveChangesAsync();
            }

            // act
            var model = new CommentInputModel { Content = "asd-new" };
            await commentsService.CreateCommentAsync(model);
            var commentFromDb = commentRepository.All().First(x => x.Content == "asd-new");

            // assert
            Assert.NotNull(commentFromDb);
        }
    }
}

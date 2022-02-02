using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Tests.Mocks;
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

            await using var dbInstance = DatabaseMock.Instance;
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    UserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel, null);
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

            await using var dbInstance = DatabaseMock.Instance;
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    UserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel, null);
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

            await using var dbInstance = DatabaseMock.Instance;
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    UserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel, null);
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
                    Id = 1, Content = "C", UserId = "asd", LessonId = 3,
                },
            };

            await using var dbInstance = DatabaseMock.Instance;
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    UserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel, null);
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
                    Id = 1, Content = "C", UserId = "asd", LessonId = 3,
                },
            }.AsQueryable();

            await using var dbInstance = DatabaseMock.Instance;
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    UserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel, null);
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
                    Id = 1, Content = "Test Content", UserId = "asd", LessonId = 3,
                },
            };

            await using var dbInstance = DatabaseMock.Instance;
            var commentRepository = new EfDeletableEntityRepository<Comment>(dbInstance);
            var commentsService = new CommentsService(commentRepository);

            foreach (var comment in data)
            {
                var inputModel = new CommentInputModel
                {
                    LessonId = 1,
                    Content = comment.Content,
                    UserId = "123",
                };

                await commentsService.CreateCommentAsync(inputModel, null);
                await commentRepository.SaveChangesAsync();
            }

            // act
            var model = new CommentInputModel { Content = "asd-new" };
            await commentsService.CreateCommentAsync(model, null);
            var commentFromDb = commentRepository.All().First(x => x.Content == "asd-new");

            // assert
            Assert.NotNull(commentFromDb);
        }
    }
}

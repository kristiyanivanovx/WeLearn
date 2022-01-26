using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Tests.Mocks;
using WeLearn.Web.ViewModels.Answer;
using Xunit;

namespace WeLearn.Tests
{
    public class AnswersServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_AnswerCreated()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var answerRepository = new EfDeletableEntityRepository<Answer>(dbInstance);
            var service = new AnswersService(answerRepository);

            var model = new AnswerInputModel
            {
                IsCorrect = true,
                Content = 123.ToString(),
                QuestionId = 3,
            };

            var answerId = 1;

            // act
            var rowsAffected = await service.CreateAsync(model);
            var containsCreated = service.Contains(answerId);
            var containsNonexistent = service.Contains(123);

            // assert
            Assert.True(containsCreated);
            Assert.False(containsNonexistent);
            Assert.Equal(1, rowsAffected);
        }

        [Fact]
        public async Task Should_Succeed_When_AnswerDeleted()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var answerRepository = new EfDeletableEntityRepository<Answer>(dbInstance);
            var service = new AnswersService(answerRepository);

            var model = new AnswerInputModel
            {
                IsCorrect = true,
                Content = 123.ToString(),
                QuestionId = 3,
            };

            var answerId = 1;

            // act
            var rowsAffected = await service.CreateAsync(model);
            await service.DeleteAsync(answerId);
            var containsDeleted = service.Contains(answerId);

            // assert
            Assert.False(containsDeleted);
            Assert.Equal(1, rowsAffected);
        }

        [Fact]
        public async Task Should_Succeed_When_AnswerEdited()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var answerRepository = new EfDeletableEntityRepository<Answer>(dbInstance);
            var service = new AnswersService(answerRepository);

            var model = new AnswerInputModel
            {
                IsCorrect = true,
                Content = 123.ToString(),
                QuestionId = 3,
            };

            await service.CreateAsync(model);

            var answerId = 1;

            var editModel = new AnswerEditModel
            {
                Id = answerId,
                IsCorrect = false,
                Content = "none",
                QuestionId = 3,
            };

            // act
            var rowsAffected = await service.EditAsync(editModel);
            var containsEdited = service.Contains(answerId);

            // assert
            Assert.True(containsEdited);
            Assert.Equal(1, rowsAffected);
        }
    }
}

using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Services.Mapping;
using WeLearn.Tests.Mocks;
using WeLearn.Web.ViewModels.Question;
using Xunit;

namespace WeLearn.Tests
{
    public class QuestionsServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_QuestionCreated()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);

            var model = new QuestionInputModel
            {
                Points = 333,
                Content = "What exactly is a cat?",
            };

            var questionId = 1;

            // act
            await service.CreateAsync(model);
            var containsExisting = service.Contains(questionId);
            var containsNotExisting = service.Contains(123);

            // assert
            Assert.True(containsExisting);
            Assert.False(containsNotExisting);
        }

        [Fact]
        public async Task Should_NotEditNonexistentQuestion()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);

            var inputModel = new QuestionInputModel
            {
                Points = 333,
                Content = "What exactly is a cat?",
            };

            var questionId = 1;
            var fictionalQuestionId = 123;

            // act
            await service.CreateAsync(inputModel);

            var editModel = new QuestionEditModel
            {
                Id = fictionalQuestionId,
                Points = 2,
                Content = "What?",
            };

            await service.EditAsync(editModel);
            var question = service.GetQuestionById(questionId);

            // assert
            Assert.NotNull(question);
            Assert.Equal(333, question.Points);
            Assert.Equal("What exactly is a cat?", question.Content);
        }

        [Fact]
        public async Task Should_EditExistingQuestion()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);

            var inputModel = new QuestionInputModel
            {
                Points = 333,
                Content = "What exactly is a cat?",
            };

            var questionId = 1;

            // act
            await service.CreateAsync(inputModel);

            var editModel = new QuestionEditModel
            {
                Id = questionId,
                Points = 2,
                Content = "What?",
            };

            await service.EditAsync(editModel);
            var question = service.GetQuestionById(questionId);

            // assert
            Assert.NotNull(question);
            Assert.Equal(2, question.Points);
            Assert.Equal("What?", question.Content);
        }

        [Fact]
        public async Task Should_ReturnCorrectResult_WhenSearchedById_AndQuestionIsNull()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);

            var model = new QuestionInputModel
            {
                Points = 3,
                Content = "What exactly is a cat?",
            };

            var fictionalQuestionId = 123;

            // act
            await service.CreateAsync(model);
            var question = service.GetQuestionById(fictionalQuestionId);

            // assert
            Assert.Null(question);
        }

        [Fact]
        public async Task Should_ReturnCorrectResult_WhenSearchedById()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);

            var model = new QuestionInputModel
            {
                Points = 333,
                Content = "What exactly is a cat?",
            };

            var questionId = 1;

            // act
            await service.CreateAsync(model);
            var question = service.GetQuestionById(questionId);

            // assert
            Assert.NotNull(question);
            Assert.Equal(333, question.Points);
            Assert.Equal("What exactly is a cat?", question.Content);
        }

        [Fact]
        public async Task Should_ReturnEarly_When_DeletingNonexistentQuestion()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);

            var model = new QuestionInputModel
            {
                Points = 333,
                Content = "What exactly is a cat?",
            };

            var questionId = 1;
            var fictionalQuestionId = 112345;

            // act
            await service.CreateAsync(model);
            await service.DeleteAsync(fictionalQuestionId);

            var containsExisting = service.Contains(questionId);
            var allQuestionsCount = service.GetAllQuestions()?.Count();

            // assert
            Assert.True(containsExisting);
            Assert.Equal(1, allQuestionsCount);
        }

        [Fact]
        public async Task Should_Succeed_When_QuestionDeleted()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);

            var model = new QuestionInputModel
            {
                Points = 333,
                Content = "What exactly is a cat?",
            };

            var questionId = 1;

            // act
            await service.CreateAsync(model);
            await service.DeleteAsync(questionId);

            var containsNotExisting = service.Contains(questionId);
            var allQuestionsCount = service.GetAllQuestions()?.Count();

            // assert
            Assert.False(containsNotExisting);
            Assert.Equal(0, allQuestionsCount);
        }

        [Fact]
        public async Task Should_ReturnAllQuestions()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);

            var modelOne = new QuestionInputModel
            {
                Points = 3,
                Content = "What exactly is a cat?",
            };

            var modelTwo = new QuestionInputModel
            {
                Points = 4,
                Content = "What exactly is Apu?",
            };

            // act
            await service.CreateAsync(modelOne);
            await service.CreateAsync(modelTwo);

            var allQuestions = service.GetAllQuestions();
            var allQuestionsCount = allQuestions?.Count();

            // assert
            Assert.NotNull(allQuestions);
            Assert.Equal(2, allQuestionsCount);
        }

        [Fact]
        public async Task Should_SucceedWhenQuestionSearchedById()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);
            AutoMapperConfig.RegisterMappings(typeof(MyTestQuestion).Assembly);

            var model = new QuestionInputModel
            {
                Points = 3,
                Content = "What exactly is a cat?",
            };

            // act
            await service.CreateAsync(model);

            var question = service.GetById<MyTestQuestion>(1);

            // assert
            Assert.NotNull(question);
            Assert.Equal("What exactly is a cat?", question.Content);
        }

        [Fact]
        public async Task Should_SucceedWhenAllQuestionsRetrieved()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var questionRepository = new EfDeletableEntityRepository<Question>(dbInstance);
            var service = new QuestionsService(questionRepository);
            AutoMapperConfig.RegisterMappings(typeof(MyTestQuestion).Assembly);

            var modelOne = new QuestionInputModel
            {
                Points = 3,
                Content = "What exactly is a cat?",
            };

            var modelTwo = new QuestionInputModel
            {
                Points = 3,
                Content = "something else ...",
            };

            // act
            await service.CreateAsync(modelOne);
            await service.CreateAsync(modelTwo);

            var questions = service.GetAll<MyTestQuestion>();

            // assert
            Assert.Equal(2, questions.Count());
        }

        public class MyTestQuestion : IMapFrom<Question>
        {
            public string Content { get; set; }
        }
    }
}

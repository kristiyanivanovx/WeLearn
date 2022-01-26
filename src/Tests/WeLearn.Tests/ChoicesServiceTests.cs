using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Tests.Mocks;
using Xunit;

namespace WeLearn.Tests
{
    public class ChoicesServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_ChoiceCreated()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var choiceRepository = new EfDeletableEntityRepository<Choice>(dbInstance);
            var service = new ChoicesService(choiceRepository);

            // act
            await service.CreateAsync(3, 4);
            await service.SaveChangesAsync();
            var count = await service.GetAllAsync();

            // assert
            Assert.Single(count);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Tests.Mocks;
using Xunit;

namespace WeLearn.Tests
{
    public class ExaminationsServiceTests
    {
        [Fact]
        public async Task Should_Succeed_When_ExaminationCreated()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var examinationRepository = new EfDeletableEntityRepository<Examination>(dbInstance);
            var service = new ExaminationsService(examinationRepository);

            // act
            var choices = new List<Choice>();
            await service.CreateAsync(3, 4, 5.ToString(), choices);
            var examination = service.Contains(1);
            var examinationsCount = service.GetCount();

            // assert
            Assert.True(examination);
            Assert.Equal(1, examinationsCount);
        }
    }
}

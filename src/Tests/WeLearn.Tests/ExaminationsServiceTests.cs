using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.Quiz;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Services.Mapping;
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

            var examinationExists = service.Contains(1);
            var examinationsCount = service.GetCount();

            // assert
            Assert.True(examinationExists);
            Assert.Equal(1, examinationsCount);
        }

        [Fact]
        public async Task Should_Succeed_When_ExaminationRetrievedById()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var examinationRepository = new EfDeletableEntityRepository<Examination>(dbInstance);
            var service = new ExaminationsService(examinationRepository);
            AutoMapperConfig.RegisterMappings(typeof(MyTestExamination).Assembly);

            // act
            var choices = new List<Choice>();
            await service.CreateAsync(3, 4, 5.ToString(), choices);

            var examination = service.GetById<MyTestExamination>(1);

            // assert
            Assert.NotNull(examination);
            Assert.Equal(4, examination.Points);
        }

        [Fact]
        public async Task Should_Succeed_When_AllExaminationsAreRetrieved()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var examinationRepository = new EfDeletableEntityRepository<Examination>(dbInstance);
            var service = new ExaminationsService(examinationRepository);
            AutoMapperConfig.RegisterMappings(typeof(MyTestExamination).Assembly);

            // act
            var choices = new List<Choice>();
            await service.CreateAsync(3, 4, 5.ToString(), choices);
            await service.CreateAsync(4, 5, 6.ToString(), choices);

            var examinations = service.GetAll<MyTestExamination>();

            // assert
            Assert.NotNull(examinations);
            Assert.Equal(2, examinations.Count());
        }

        public class MyTestExamination : IMapFrom<Examination>
        {
            public int Points { get; set; }
        }
    }
}

using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Tests.Mocks;
using Xunit;

namespace WeLearn.Tests
{
    public class LikesServiceTests
    {
        [Fact]
        public async Task Should_Return_CorrectLikeCount()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var likeRepository = new EfDeletableEntityRepository<Like>(dbInstance);
            var service = new LikesService(likeRepository);

            // act
            var likesCount = service.GetLikesCount(1);

            // assert
            Assert.Equal(0, likesCount);
        }

        [Fact]
        public async Task Should_CreateLike()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var likeRepository = new EfDeletableEntityRepository<Like>(dbInstance);
            var service = new LikesService(likeRepository);

            // act
            await service.AddLikeAsync(1, 1.ToString());
            var likesCount = service.GetLikesCount(1);

            // assert
            Assert.Equal(1, likesCount);
        }

        [Fact]
        public async Task Should_RemoveLike_WhenLikeToggled()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var likeRepository = new EfDeletableEntityRepository<Like>(dbInstance);
            var service = new LikesService(likeRepository);

            // act
            await service.AddLikeAsync(1, 1.ToString());
            await service.ToggleLikeAsync(1, 1.ToString());
            var likesCount = service.GetLikesCount(1);

            // assert
            Assert.Equal(0, likesCount);
        }

        [Fact]
        public async Task Should_AddLike_WhenLikeToggledTwoTimes()
        {
            // arrange
            await using var dbInstance = DatabaseMock.Instance;
            var likeRepository = new EfDeletableEntityRepository<Like>(dbInstance);
            var service = new LikesService(likeRepository);

            // act
            await service.AddLikeAsync(1, 1.ToString());
            await service.ToggleLikeAsync(1, 1.ToString());
            await service.ToggleLikeAsync(1, 1.ToString());
            var likesCount = service.GetLikesCount(1);

            // assert
            Assert.Equal(1, likesCount);
        }
    }
}

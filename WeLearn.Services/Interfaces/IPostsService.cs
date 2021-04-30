using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.Interfaces;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface IPostsService
    {
        Task<int> GetAllPostsCountAsync();

        Task<T> GetPostByIdAsync<T>(int id);

        Task<IEnumerable<T>> GetAllPostsAsync<T>();

        Task<IEnumerable<T>> UploadedByMeAsync<T>(string userId);

        Task<IEnumerable<T>> GetAllPostsByCategoryNameAsync<T>(string categoryName);

        Task CreatePostAsync(PostInputModel postInputModel, dynamic environmentWebRootPath, string userId);

        Task EditPostAsync(PostEditModel postEditModel, dynamic environmentWebRootPath, string userId);

        Task DeletePostAsync(int id);

        Task UploadMaterialsAsync<T>(T postModel, dynamic uploadsMaterials) where T : IPostModel;

        Task<Video> UploadVideoAsync<T>(T postModel, dynamic environmentWebRootPath) where T : IPostModel;
    }
}

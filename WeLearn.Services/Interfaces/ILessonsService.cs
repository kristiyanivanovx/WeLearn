using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.ViewModels.Interfaces;
using WeLearn.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface ILessonsService
    {
        Task<int> GetAllLessonsCountAsync();

        Task<IEnumerable<LessonViewModel>> GetCreatedByMeAsync(string userId);

        Task<IEnumerable<LessonViewModel>> GetAllLessonsAsync(string categoryName);

        Task<T> GetLessonByIdAsync<T>(int id);

        Task<IEnumerable<LessonViewModel>> GetAllLessonsByCategoryAsync(string categoryName, string searchString);

        Task CreateLessonAsync(LessonInputModel lessonInputModel, dynamic environmentWebRootPath, string environmentName, string userId);

        Task EditLessonAsync(LessonEditModel lessonEditModel, dynamic environmentWebRootPath, string environmentName, string userId);

        Task SoftDeleteLessonByIdAsync(int lessonId);

        Task UploadMaterialsAsync(ILessonModel model, dynamic uploadsMaterials);

        Task<Video> UploadVideoAsync(ILessonModel model, dynamic environmentWebRootPath);
    }
}

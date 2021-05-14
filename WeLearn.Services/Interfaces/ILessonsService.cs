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

        Task<T> GetLessonByIdAsync<T>(int id);

        Task<T> GetLessonByIdAdministrationAsync<T>(int id);

        Task<IEnumerable<T>> GetAllLessonsAsync<T>(string categoryName = null);

        Task<IEnumerable<T>> GetAllLessonsAdministrationAsync<T>(string categoryName = null);

        Task<IEnumerable<LessonViewModel>> GetCreatedByMeAsync(string userId);

        Task<IEnumerable<LessonViewModel>> GetAllLessonsByCategoryAsync(string categoryName, string searchString);

        Task CreateLessonAsync(LessonInputModel lessonInputModel, string environmentWebRootPath, string environmentName, string userId);

        Task EditLessonAsync(LessonEditModel lessonEditModel, string environmentWebRootPath, string environmentName, string userId);

        Task EditLessonAdministrationAsync(AdministrationLessonModel model);

        Task SoftDeleteLessonByIdAsync(int lessonId);

        Task HardDeleteLessonByIdAsync(int lessonId);
        
        Task UploadMaterialsAsync(ILessonModel model, string uploadsMaterials);

        Task<Video> UploadVideoAsync(ILessonModel model, string environmentWebRootPath);
    }
}

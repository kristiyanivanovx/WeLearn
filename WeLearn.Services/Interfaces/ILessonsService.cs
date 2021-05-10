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

        Task<IEnumerable<LessonViewModel>> GetAllLessonsAsync(string categoryName);

        Task<IEnumerable<LessonViewModel>> UploadedByMeAsync(string userId);

        Task<IEnumerable<LessonViewModel>> GetAllRelevantLessonsAsync(string categoryName, string searchString);

        Task DeleteLessonAsync(Lesson lesson);

        Task CreateLessonAsync(LessonInputModel lessonInputModel, dynamic environmentWebRootPath, string environmentName, string userId);

        Task EditLessonAsync(LessonEditModel lessonEditModel, dynamic environmentWebRootPath, string environmentName, string userId);

        Task UploadMaterialsAsync(ILessonModel model, dynamic uploadsMaterials);

        Task<Video> UploadVideoAsync(ILessonModel model, dynamic environmentWebRootPath);

        Task<T> GetLessonByIdAsync<T>(int id);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.ViewModels.Interfaces;
using WeLearn.ViewModels;
using WeLearn.ViewModels.Lesson;
using WeLearn.ViewModels.Admin;
using WeLearn.ViewModels.Admin.Lesson;
using WeLearn.Data.Models.Enums;

namespace WeLearn.Services.Interfaces
{
    public interface ILessonsService
    {
        int GetAllLessonsCount();

        Task<T> GetLessonByIdAsync<T>(int id);

        Task<T> GetLessonByIdAdministrationAsync<T>(int id);

        Task<IEnumerable<T>> GetAllLessonsAsync<T>(string categoryName = null);

        Task<IEnumerable<T>> GetAllLessonsAdministrationAsync<T>(string categoryName = null);

        Task<IEnumerable<LessonViewModel>> GetCreatedByMeAsync(string userId, string searchString);

        Task<IEnumerable<LessonViewModel>> GetLessonsByCategoryAndCategoryAsync(string categoryName, string searchString, int grade);

        Task CreateLessonAsync(LessonInputModel lessonInputModel, string environmentWebRootPath, bool isDevelopment, string userId);

        Task EditLessonAsync(LessonEditModel lessonEditModel, string environmentWebRootPath, bool isDevelopment, string userId);

        Task EditLessonAdministrationAsync(AdminLessonEditModel model);

        Task SoftDeleteLessonByIdAsync(int lessonId);

        Task HardDeleteLessonByIdAsync(int lessonId);
        
        Task UploadMaterialsAsync(ILessonModel model, string uploadsMaterials);

        Task<Video> UploadVideoAsync(Lesson lesson, ILessonModel model, string environmentWebRootPath);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;
using WeLearn.Web.ViewModels.Admin.Lesson;
using WeLearn.Web.ViewModels.Interfaces;
using WeLearn.Web.ViewModels.Lesson;

namespace WeLearn.Services.Data.Interfaces
{
    public interface ILessonsService
    {
        Task<IEnumerable<T>> GetLikedByUserId<T>(string userId, string searchString);

        bool Contains(int id);

        int GetCount();

        Task<T> GetLessonByIdAsync<T>(int id);

        Task<T> GetLessonByIdWithDeletedAsync<T>(int id);

        Task<IEnumerable<T>> GetAllLessonsAsync<T>(string searchString = null);

        Task<IEnumerable<T>> GetAllLessonsWithDeletedAsync<T>(string categoryName = null);

        Task<IEnumerable<LessonViewModel>> GetCreatedByMeAsync(string userId, string searchString);

        Task<IEnumerable<LessonViewModel>> GetLessonsByCategoryAndGradeAsync(
            string categoryName,
            string searchString,
            int grade);

        Task CreateLessonAsync(
            LessonInputModel lessonInputModel,
            string environmentWebRootPath,
            bool isDevelopment,
            string userId);

        Task EditLessonAsync(
            LessonEditModel lessonEditModel,
            string environmentWebRootPath,
            bool isDevelopment,
            string userId);

        Task EditLessonAdministrationAsync(AdminLessonEditModel model);

        Task SoftDeleteLessonByIdAsync(int lessonId);

        Task HardDeleteLessonByIdAsync(int lessonId);

        Task UploadMaterialsAsync(ILessonModel model, string uploadsMaterials);

        Task<Video> UploadVideoAsync(Lesson lesson, ILessonModel model, string environmentWebRootPath);
    }
}

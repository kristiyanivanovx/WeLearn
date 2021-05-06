using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.Interfaces;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services.Interfaces
{
    public interface ILessonsService
    {
        Task<int> GetAllLessonsCountAsync();

        Task<IEnumerable<LessonViewModel>> GetAllLessonsToVMAsync();

        Task<IEnumerable<LessonViewModel>> UploadedByMeToVMAsync(string userId);

        Task<IEnumerable<LessonViewModel>> GetAllRelevantLessonsToVMAsync(string categoryName);

        Task DeleteLessonAsync(Lesson lesson);

        Task CreateLessonAsync(LessonInputModel lessonInputModel, dynamic environmentWebRootPath, string environmentName, string userId);

        Task EditLessonAsync(LessonEditModel lessonEditModel, dynamic environmentWebRootPath, string environmentName, string userId);

        Task UploadMaterialsAsync<T>(T model, dynamic uploadsMaterials) where T : ILessonModel;

        Task<Video> UploadVideoAsync<T>(T model, dynamic environmentWebRootPath) where T : ILessonModel;

        Task<T> GetLessonByIdAsync<T>(int id);
    }
}

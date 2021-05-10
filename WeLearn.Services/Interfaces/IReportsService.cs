using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.ViewModels.Interfaces;
using WeLearn.ViewModels;

namespace WeLearn.Services
{
    public interface IReportsService
    {
        Task EditLessonReportAsync(LessonReportModel model);

        Task<IEnumerable<LessonReportModel>> LessonReportsCreatedByMeAsync(string userId);

        Task<IEnumerable<CommentReportModel>> CommentReportsCreatedByMeAsync(string userId);

        Task<Report> GetReportByIdToReportAsync(int reportId);

        Task EditCommentReportAsync(CommentReportModel commentReportModel);

        Task DeleteReportAsync(Report model);

        Task CreateReportAsync<T>(T model) where T : IReportModel;

        Task<T> GetReportById<T>(int reportId) where T : IReportModel;
    }
}

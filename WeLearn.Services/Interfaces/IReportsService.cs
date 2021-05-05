using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.Interfaces;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services
{
    public interface IReportsService
    {
        Task EditLessonReportAsync(LessonReportModel model);

        Task<IEnumerable<LessonReportModel>> CreatedByMeToLessonReportVMAsync(string userId);

        Task<IEnumerable<CommentReportModel>> CreatedByMeToCommentReportVMAsync(string userId);

        Task<Report> GetReportByIdToReportAsync(int reportId);

        Task EditCommentReportAsync(CommentReportModel commentReportModel);

        Task DeleteReportAsync(Report model);

        Task CreateReportAsync<T>(T model) where T : IReportModel;

        Task<T> GetReportById<T>(int reportId) where T : IReportModel;
    }
}

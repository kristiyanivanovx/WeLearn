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

        Task SoftDeleteReportByIdAsync(int? reportId);

        Task CreateReportAsync(IReportModel model);

        Task<IReportModel> GetReportById<IReportModel>(int reportId);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.ViewModels.Interfaces;
using WeLearn.ViewModels;

namespace WeLearn.Services
{
    public interface IReportsService
    {
        Task<IEnumerable<AdministrationReportModel>> GetAllReportsAsync(string searchString = null);

        Task<IEnumerable<LessonReportModel>> GetLessonReportsCreatedByMeAsync(string userId);

        Task<IEnumerable<CommentReportModel>> GetCommentReportsCreatedByMeAsync(string userId);

        Task<IReportModel> GetReportByIdAsync<IReportModel>(int reportId);

        Task CreateReportAsync(IReportModel model);

        Task EditCommentReportAsync(CommentReportModel commentReportModel);

        Task EditLessonReportAsync(LessonReportModel model);

        Task EditReportAdministrationAsync(AdministrationReportModel model);

        Task SoftDeleteReportByIdAsync(int? reportId);

        Task HardDeleteReportByIdAsync(int reportId);
    }
}

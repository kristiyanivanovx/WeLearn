using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.ViewModels.Admin.Report;
using WeLearn.ViewModels.Report.Comment;
using WeLearn.ViewModels.Report.Lesson;

namespace WeLearn.Services
{
    public interface IReportsService
    {
        Task<T> GetReportByIdAsync<T>(int reportId);

        Task<IEnumerable<T>> GetAllReportsAsync<T>(string searchString = null);

        Task<IEnumerable<LessonReportViewModel>> GetLessonReportsCreatedByMeAsync(string userId);

        Task<IEnumerable<CommentReportViewModel>> GetCommentReportsCreatedByMeAsync(string userId);

        Task CreateReportAsync<T>(T model);

        Task EditCommentReportAsync(CommentReportEditModel commentReportModel);

        Task EditLessonReportAsync(LessonReportEditModel model);

        Task EditReportAdministrationAsync(AdminReportEditModel model);

        Task SoftDeleteReportByIdAsync(int? reportId);

        Task HardDeleteReportByIdAsync(int reportId);
    }
}

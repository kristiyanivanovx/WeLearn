using System.Collections.Generic;
using System.Threading.Tasks;

using WeLearn.Web.ViewModels.Admin.Report;
using WeLearn.Web.ViewModels.Report.Comment;
using WeLearn.Web.ViewModels.Report.Lesson;

namespace WeLearn.Services.Interfaces
{
    public interface IReportsService
    {
        int GetCount();

        Task<T> GetReportByIdAsync<T>(int reportId);

        Task<IEnumerable<T>> GetAllReportsAsync<T>(string searchString = null);

        Task<IEnumerable<LessonReportViewModel>> GetLessonReportsCreatedByMeAsync(string userId);

        Task<IEnumerable<CommentReportViewModel>> GetCommentReportsCreatedByMeAsync(string userId);

        Task CreateLessonReportAsync(LessonReportInputModel model);

        Task CreateCommentReportAsync(CommentReportInputModel model);

        Task EditCommentReportAsync(CommentReportEditModel commentReportModel);

        Task EditLessonReportAsync(LessonReportEditModel model);

        Task EditReportAdministrationAsync(AdminReportEditModel model);

        Task SoftDeleteReportByIdAsync(int? reportId);

        Task HardDeleteReportByIdAsync(int reportId);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.Interfaces;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services
{
    public interface IReportsService
    {
        Task<Report> GetReportByIdToReportAsync(int reportId);

        Task EditPostReportAsync(PostReportModel model);

        Task DeletePostReportAsync(Report model);

        Task CreateReportAsync<T>(T model) where T : IReportModel;

        Task<T> GetReportById<T>(int reportId) where T : IReportModel;

        Task<IEnumerable<T>> CreatedByMeAsync<T>(string userId) where T : IReportModel;
    }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data.Context;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.Interfaces;
using WeLearn.Infrastructure.ViewModels;

namespace WeLearn.Services
{
    public class ReportsService : IReportsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ReportsService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task CreateReportAsync<T>(T model) where T : IReportModel
        {
            var reportMapped = mapper.Map<Report>(model);
            await context.Reports.AddAsync(reportMapped);
            await context.SaveChangesAsync();
        }

        public async Task EditPostReportAsync(PostReportModel postReportModel)
        {
            var entity = context.Reports.FirstOrDefault(x => x.ReportId == postReportModel.ReportId);

            entity.Subject = postReportModel.Subject ?? entity.Subject;
            entity.Description = postReportModel.ReportDescription ?? entity.Description;

            await context.SaveChangesAsync();
        }

        public async Task<T> GetReportById<T>(int reportId) where T : IReportModel
        {
            var reportByMe = await context.Reports
                .Where(x => x.ReportId == reportId)
                .Include(x => x.Post)
                .Include(x => x.Post.Video)
                .Include(x => x.Post.Material)
                .Include(x => x.Post.Category)
                .Include(x => x.Post.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .FirstOrDefaultAsync();

            var reportByIdMapped = mapper.Map<T>(reportByMe);
            return reportByIdMapped;
        }

        // refactor later
        public async Task<Report> GetReportByIdToReportAsync(int reportId)
        {
            var reportByMe = await context.Reports
                .Where(x => x.ReportId == reportId)
                .Include(x => x.Post)
                .Include(x => x.Post.Video)
                .Include(x => x.Post.Material)
                .Include(x => x.Post.Category)
                .Include(x => x.Post.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .FirstOrDefaultAsync();

            var reportByIdMapped = mapper.Map<Report>(reportByMe);
            return reportByIdMapped;
        }

        //ReportViewModel
        public async Task<IEnumerable<T>> CreatedByMeAsync<T>(string userId) where T : IReportModel
        {
            var postsByMe = await context.Reports
                .Where(x => x.ApplicationUserId == userId)
                .Include(x => x.Post)
                .Include(x => x.Post.Video)
                .Include(x => x.Post.Material)
                .Include(x => x.Post.Category)
                .Include(x => x.Post.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .ToListAsync();

            var postsByMeMapped = mapper.Map<T[]>(postsByMe);
            return postsByMeMapped;
        }

        public async Task DeletePostReportAsync(Report report)
        {
            var reportFromDb = await context.Reports.FirstOrDefaultAsync(x => x.ReportId == report.ReportId);
            reportFromDb.IsDeleted = true;
            await context.SaveChangesAsync();
        }
    }
}

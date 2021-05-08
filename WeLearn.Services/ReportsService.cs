using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
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

        public async Task EditLessonReportAsync(LessonReportModel lessonReportModel)
        {
            var entity = context.Reports.FirstOrDefault(x => x.Id == lessonReportModel.ReportId);
            entity.Subject = lessonReportModel.Subject ?? entity.Subject;
            entity.Description = lessonReportModel.ReportDescription ?? entity.Description;
            await context.SaveChangesAsync();
        }

        public async Task<T> GetReportById<T>(int reportId) where T : IReportModel
        {
            var reportByMe = await context.Reports
                .Where(x => x.Id == reportId)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Comment)
                .FirstOrDefaultAsync();

            var reportByIdMapped = mapper.Map<T>(reportByMe);
            return reportByIdMapped;
        }

        public async Task<Report> GetReportByIdToReportAsync(int reportId)
        {
            var reportByMe = await context.Reports
                .Where(x => x.Id == reportId)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .FirstOrDefaultAsync();

            var reportByIdMapped = mapper.Map<Report>(reportByMe);
            return reportByIdMapped;
        }

        public async Task<IEnumerable<LessonReportModel>> CreatedByMeToLessonReportVMAsync(string userId)
        {
            var lessonsByMe = await context.Reports
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted && x.LessonId != null)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .ToListAsync();

            var lessonsByMeMapped = mapper.Map<LessonReportModel[]>(lessonsByMe);
            return lessonsByMeMapped;
        }

        public async Task EditCommentReportAsync(CommentReportModel commentReportModel)
        {
            var entity = context.Reports.FirstOrDefault(x => x.Id == commentReportModel.ReportId);
            entity.Subject = commentReportModel.Subject ?? entity.Subject;
            entity.Description = commentReportModel.ReportDescription ?? entity.Description;
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CommentReportModel>> CreatedByMeToCommentReportVMAsync(string userId)
        {
            var commentsByMe = await context.Reports
                .Where(x => x.ApplicationUserId == userId && x.IsDeleted == false && x.CommentId != null)
                .Include(x => x.Comment)
                .Include(x => x.ApplicationUser)
                .ToListAsync();

            var commentsReportedByMeMapped = mapper.Map<CommentReportModel[]>(commentsByMe);
            return commentsReportedByMeMapped;
        }

        public async Task DeleteReportAsync(Report report)
        {
            report.IsDeleted = true;
            await context.SaveChangesAsync();
        }
    }
}

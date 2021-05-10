using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.ViewModels.Interfaces;
using WeLearn.ViewModels;
using System;

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

        public async Task CreateReportAsync(IReportModel model)
        {
            Report reportMapped = mapper.Map<Report>(model);
            reportMapped.DateCreated = DateTime.UtcNow;

            await context.Reports.AddAsync(reportMapped);
            await context.SaveChangesAsync();
        }

        public async Task EditLessonReportAsync(LessonReportModel lessonReportModel)
        {
            Report entity = context.Reports.FirstOrDefault(x => x.Id == lessonReportModel.ReportId);
            entity.Subject = lessonReportModel.Subject ?? entity.Subject;
            entity.Description = lessonReportModel.ReportDescription ?? entity.Description;
            await context.SaveChangesAsync();
        }

        public async Task<IReportModel> GetReportById<IReportModel>(int reportId)
        {
            Report reportByMe = await context.Reports
                    .Where(x => x.Id == reportId)
                    .Include(x => x.Lesson)
                    .Include(x => x.Lesson.Video)
                    .Include(x => x.Lesson.Material)
                    .Include(x => x.Lesson.Category)
                    .Include(x => x.Lesson.ApplicationUser)
                    .Include(x => x.ApplicationUser)
                    .Include(x => x.Comment)
                    .FirstOrDefaultAsync();

            IReportModel reportByIdMapped = mapper.Map<IReportModel>(reportByMe);
            return reportByIdMapped;
        }

        public async Task<Report> GetReportByIdToReportAsync(int reportId)
        {
            Report report = await context.Reports
                    .Where(x => x.Id == reportId)
                    .Include(x => x.Lesson)
                    .Include(x => x.Lesson.Video)
                    .Include(x => x.Lesson.Material)
                    .Include(x => x.Lesson.Category)
                    .Include(x => x.Lesson.ApplicationUser)
                    .Include(x => x.ApplicationUser)
                    .FirstOrDefaultAsync();

            return report;
        }

        public async Task<IEnumerable<LessonReportModel>> LessonReportsCreatedByMeAsync(string userId)
        {
            List<Report> lessonsReportedByMe = await context.Reports
                            .Where(x => x.ApplicationUserId == userId && !x.IsDeleted && x.LessonId != null)
                            .Include(x => x.Lesson)
                            .Include(x => x.Lesson.Video)
                            .Include(x => x.Lesson.Material)
                            .Include(x => x.Lesson.Category)
                            .Include(x => x.Lesson.ApplicationUser)
                            .Include(x => x.ApplicationUser)
                            .ToListAsync();

            LessonReportModel[] lessonsByMeMapped = mapper.Map<LessonReportModel[]>(lessonsReportedByMe);
            return lessonsByMeMapped;
        }

        public async Task EditCommentReportAsync(CommentReportModel commentReportModel)
        {
            Report entity = context.Reports.FirstOrDefault(x => x.Id == commentReportModel.ReportId);
            entity.Subject = commentReportModel.Subject ?? entity.Subject;
            entity.Description = commentReportModel.ReportDescription ?? entity.Description;
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CommentReportModel>> CommentReportsCreatedByMeAsync(string userId)
        {
            List<Report> commentsByMe = await context.Reports
                .Where(x => x.ApplicationUserId == userId && x.IsDeleted == false && x.CommentId != null)
                .Include(x => x.Comment)
                .Include(x => x.ApplicationUser)
                .ToListAsync();

            CommentReportModel[] commentsReportedByMeMapped = mapper.Map<CommentReportModel[]>(commentsByMe);
            return commentsReportedByMeMapped;
        }

        public async Task SoftDeleteReportByIdAsync(int? reportId)
        {
            Report report = context.Reports.FirstOrDefault(x => x.Id == reportId);
            report.IsDeleted = true;
            await context.SaveChangesAsync();
        }
    }
}

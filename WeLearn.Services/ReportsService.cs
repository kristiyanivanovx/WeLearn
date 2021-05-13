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

        public async Task<IEnumerable<LessonReportModel>> GetLessonReportsCreatedByMeAsync(string userId)
        {
            List<Report> lessonsReportedByMe = await context.Reports
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted && x.LessonId != null)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .ToListAsync();

            LessonReportModel[] lessonsByMeMapped = mapper.Map<LessonReportModel[]>(lessonsReportedByMe);
            return lessonsByMeMapped;
        }

        public async Task<IEnumerable<CommentReportModel>> GetCommentReportsCreatedByMeAsync(string userId)
        {
            List<Report> commentsByMe = await context.Reports
                .Include(x => x.Comment)
                .Include(x => x.Comment.ApplicationUser)
                .Where(x => x.ApplicationUserId == userId && x.IsDeleted == false && x.CommentId != null && !x.Comment.IsDeleted)
                .ToListAsync();

            CommentReportModel[] commentsReportedByMeMapped = mapper.Map<CommentReportModel[]>(commentsByMe);
            return commentsReportedByMeMapped;
        }

        public async Task<IEnumerable<AdministrationReportModel>> GetAllReportsAsync(string searchString)
        {
            IQueryable<Report> reports = context.Reports;

            if (!string.IsNullOrEmpty(searchString))
            {
                reports = reports.Where(x => x.Subject.ToLower().Contains(searchString.ToLower()) ||
                                                     x.Description.ToLower().Contains(searchString.ToLower()));
            }

            await reports
                .Include(x => x.ApplicationUser)
                .Include(x => x.Lesson)
                .Include(x => x.Comment)
                .ToListAsync();

            AdministrationReportModel[] reportsMapped = mapper.Map<AdministrationReportModel[]>(reports);
            return reportsMapped;
        }

        public async Task CreateReportAsync(IReportModel model)
        {
            Report reportMapped = mapper.Map<Report>(model);
            reportMapped.DateCreated = DateTime.UtcNow;

            await context.Reports.AddAsync(reportMapped);
            await context.SaveChangesAsync();
        }

        public async Task EditLessonReportAsync(LessonReportModel model)
        {
            Report entity = context.Reports.FirstOrDefault(x => x.Id == model.ReportId);
            entity.Subject = model.Subject ?? entity.Subject;
            entity.Description = model.ReportDescription ?? entity.Description;
            await context.SaveChangesAsync();
        }

        public async Task EditCommentReportAsync(CommentReportModel model)
        {
            Report entity = context.Reports.FirstOrDefault(x => x.Id == model.ReportId);
            entity.Subject = model.Subject ?? entity.Subject;
            entity.Description = model.ReportDescription ?? entity.Description;
            await context.SaveChangesAsync();
        }

        public async Task EditReportAdministrationAsync(AdministrationReportModel model)
        {
            Report entity = context.Reports.FirstOrDefault(x => x.Id == model.Id);
            entity.Subject = model.Subject ?? entity.Subject;
            entity.Description = model.Description ?? entity.Description;
            entity.IsDeleted = model.IsDeleted;
            entity.DateCreated = model.DateCreated;
            await context.SaveChangesAsync();
        }

        public async Task SoftDeleteReportByIdAsync(int? reportId)
        {
            Report report = context.Reports.FirstOrDefault(x => x.Id == reportId);
            report.IsDeleted = true;
            await context.SaveChangesAsync();
        }

        public async Task HardDeleteReportByIdAsync(int reportId)
        {
            Report report = context.Reports.FirstOrDefault(x => x.Id == reportId);
            context.Remove(report);
            await context.SaveChangesAsync();
        }
    }
}

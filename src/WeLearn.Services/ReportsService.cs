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
using WeLearn.ViewModels.Comment;
using WeLearn.ViewModels.Report;
using WeLearn.ViewModels.Admin;
using WeLearn.ViewModels.Admin.Report;
using WeLearn.ViewModels.Report.Comment;
using WeLearn.ViewModels.Report.Lesson;

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

        public async Task<T> GetReportByIdAsync<T>(int reportId)
        {
            Report reportByMe = await this.context.Reports
                .Where(x => x.Id == reportId)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Comment)
                .FirstOrDefaultAsync();

            T reportByIdMapped = this.mapper.Map<T>(reportByMe);
            return reportByIdMapped;
        }

        public async Task<IEnumerable<LessonReportViewModel>> GetLessonReportsCreatedByMeAsync(string userId)
        {
            List<Report> lessonsReportedByMe = await this.context.Reports
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted && x.LessonId != null && !x.Lesson.IsDeleted)
                .ToListAsync();

            LessonReportViewModel[] lessonsByMeMapped = this.mapper.Map<LessonReportViewModel[]>(lessonsReportedByMe);
            return lessonsByMeMapped;
        }

        public async Task<IEnumerable<CommentReportViewModel>> GetCommentReportsCreatedByMeAsync(string userId)
        {
            List<Report> commentsByMe = await this.context.Reports
                .Include(x => x.Comment)
                .Include(x => x.Comment.ApplicationUser)
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted && x.CommentId != null && !x.Comment.IsDeleted)
                .ToListAsync();

            CommentReportViewModel[] commentsReportedByMeMapped = this.mapper.Map<CommentReportViewModel[]>(commentsByMe);
            return commentsReportedByMeMapped;
        }

        public async Task<IEnumerable<T>> GetAllReportsAsync<T>(string searchString)
        {
            IQueryable<Report> reports = this.context.Reports;

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

            T[] reportsMapped = this.mapper.Map<T[]>(reports);
            return reportsMapped;
        }

        public async Task CreateReportAsync<T>(T model)
        {
            Report reportMapped = this.mapper.Map<Report>(model);
            reportMapped.DateCreated = DateTime.UtcNow;
            await this.context.Reports.AddAsync(reportMapped);
            await this.context.SaveChangesAsync();
        }

        public async Task EditLessonReportAsync(LessonReportEditModel model)
        {
            Report entity = this.context.Reports.FirstOrDefault(x => x.Id == model.ReportId);
            entity.Subject = model.Subject ?? entity.Subject;
            entity.Description = model.ReportDescription ?? entity.Description;
            await this.context.SaveChangesAsync();
        }

        public async Task EditCommentReportAsync(CommentReportEditModel model)
        {
            Report entity = this.context.Reports.FirstOrDefault(x => x.Id == model.ReportId);
            entity.Subject = model.Subject ?? entity.Subject;
            entity.Description = model.ReportDescription ?? entity.Description;
            await this.context.SaveChangesAsync();
        }

        public async Task EditReportAdministrationAsync(AdminReportEditModel model)
        {
            Report entity = this.context.Reports.FirstOrDefault(x => x.Id == model.Id);
            entity.Subject = model.Subject ?? entity.Subject;
            entity.Description = model.Description ?? entity.Description;
            entity.IsDeleted = model.IsDeleted;
            entity.DateCreated = model.DateCreated;
            await this.context.SaveChangesAsync();
        }

        public async Task SoftDeleteReportByIdAsync(int? reportId)
        {
            Report report = this.context.Reports.FirstOrDefault(x => x.Id == reportId);
            report.IsDeleted = true;
            await this.context.SaveChangesAsync();
        }

        public async Task HardDeleteReportByIdAsync(int reportId)
        {
            Report report = this.context.Reports.FirstOrDefault(x => x.Id == reportId);
            this.context.Remove(report);
            await this.context.SaveChangesAsync();
        }
    }
}

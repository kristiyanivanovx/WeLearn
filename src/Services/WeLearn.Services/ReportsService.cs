using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Admin.Report;
using WeLearn.Web.ViewModels.Report.Comment;
using WeLearn.Web.ViewModels.Report.Lesson;

namespace WeLearn.Services
{
    public class ReportsService : IReportsService
    {
        private readonly IDeletableEntityRepository<Report> reportRepository;

        public ReportsService(IDeletableEntityRepository<Report> reportRepository)
            => this.reportRepository = reportRepository;

        public bool Contains(int id)
            => this.reportRepository
                .All()
                .Any(x => x.Id == id);

        public int GetCount()
            => this.reportRepository
                .All()
                .Count();

        public async Task<T> GetReportByIdAsync<T>(int reportId)
            => await this.reportRepository
                .All()
                .Where(x => x.Id == reportId)
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Comment)
                .To<T>()
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<LessonReportViewModel>> GetLessonReportsCreatedByMeAsync(string userId)
            => await this.reportRepository
                .All()
                .Include(x => x.Lesson)
                .Include(x => x.Lesson.Video)
                .Include(x => x.Lesson.Material)
                .Include(x => x.Lesson.Category)
                .Include(x => x.Lesson.ApplicationUser)
                .Where(x => x.ApplicationUserId == userId && x.LessonId != null && !x.Lesson.IsDeleted)
                .To<LessonReportViewModel>()
                .ToListAsync();

        public async Task<IEnumerable<CommentReportViewModel>> GetCommentReportsCreatedByMeAsync(string userId)
            => await this.reportRepository
                .All()
                .Include(x => x.Comment)
                .Include(x => x.Comment.ApplicationUser)
                .Where(x => x.ApplicationUserId == userId && x.CommentId != null && !x.Comment.IsDeleted)
                .To<CommentReportViewModel>()
                .ToListAsync();

        public async Task<IEnumerable<T>> GetAllReportsAsync<T>(string searchString)
        {
            IQueryable<Report> reports = this.reportRepository.AllWithDeleted();

            if (!string.IsNullOrEmpty(searchString))
            {
                reports = reports.Where(x => x.Subject.ToLower().Contains(searchString.ToLower()) ||
                                             x.Description.ToLower().Contains(searchString.ToLower()));
            }

            var reportsMapped = await reports
                .Include(x => x.ApplicationUser)
                .Include(x => x.Lesson)
                .Include(x => x.Comment)
                .To<T>()
                .ToListAsync();

            return reportsMapped;
        }

        public async Task CreateLessonReportAsync(LessonReportInputModel model)
        {
            Report report = new Report
            {
                LessonId = model.LessonId,
                Subject = model.Subject,
                Description = model.ReportDescription,
                ApplicationUserId = model.ApplicationUserId,
            };

            await this.reportRepository.AddAsync(report);
            await this.reportRepository.SaveChangesAsync();
        }

        public async Task CreateCommentReportAsync(CommentReportInputModel model)
        {
            Report report = new Report
            {
                CommentId = model.CommentId,
                Subject = model.Subject,
                Description = model.ReportDescription,
                ApplicationUserId = model.ApplicationUserId,
            };

            await this.reportRepository.AddAsync(report);
            await this.reportRepository.SaveChangesAsync();
        }

        public async Task EditLessonReportAsync(LessonReportEditModel model)
        {
            Report entity = this.reportRepository.All().FirstOrDefault(x => x.Id == model.ReportId);
            if (entity != null)
            {
                entity.Subject = model.Subject ?? entity.Subject;
                entity.Description = model.ReportDescription ?? entity.Description;
            }

            await this.reportRepository.SaveChangesAsync();
        }

        public async Task EditCommentReportAsync(CommentReportEditModel model)
        {
            Report entity = this.reportRepository.All().FirstOrDefault(x => x.Id == model.ReportId);
            if (entity != null)
            {
                entity.Subject = model.Subject ?? entity.Subject;
                entity.Description = model.ReportDescription ?? entity.Description;
            }

            await this.reportRepository.SaveChangesAsync();
        }

        public async Task EditReportAdministrationAsync(AdminReportEditModel model)
        {
            Report entity = this.reportRepository.AllWithDeleted().FirstOrDefault(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.Subject = model?.Subject ?? entity.Subject;
                entity.Description = model?.Description ?? entity.Description;

                if (model.IsDeleted)
                {
                    this.reportRepository.Delete(entity);
                }
                else
                {
                    this.reportRepository.Undelete(entity);
                }
            }

            await this.reportRepository.SaveChangesAsync();
        }

        public async Task SoftDeleteReportByIdAsync(int? reportId)
        {
            Report report = this.reportRepository.All().FirstOrDefault(x => x.Id == reportId);

            this.reportRepository.Delete(report);
            await this.reportRepository.SaveChangesAsync();
        }

        public async Task HardDeleteReportByIdAsync(int reportId)
        {
            Report report = this.reportRepository.AllWithDeleted().FirstOrDefault(x => x.Id == reportId);
            this.reportRepository.HardDelete(report);
            await this.reportRepository.SaveChangesAsync();
        }
    }
}

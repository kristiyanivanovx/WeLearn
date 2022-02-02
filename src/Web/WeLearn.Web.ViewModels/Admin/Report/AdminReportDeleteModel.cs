using System;

using Ganss.XSS;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Admin.Report
{
    public class AdminReportDeleteModel : IMapFrom<Data.Models.LessonModule.Report>
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }

        public string UserUserName { get; set; }

        public string UserEmail { get; set; }

        public int? LessonId { get; set; }

        public string LessonName { get; set; }

        public string LessonDescription { get; set; }

        public int? CommentId { get; set; }

        public string CommentContent { get; set; }

        public string SanitizedCommentContent => new HtmlSanitizer().Sanitize(this.CommentContent);

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}

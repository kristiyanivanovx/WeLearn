using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.ViewModels.Interfaces;
using static WeLearn.Data.Infrastructure.DataValidation.Report;

namespace WeLearn.ViewModels.Report.Comment
{
    public class CommentReportEditModel
    {
        public int OriginId { get; set; }

        public int? ReportId { get; set; }

        public string OriginApplicationUserUserName { get; set; }

        public string CommentContent { get; set; }

        public DateTime CommentDateCreated { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedByUserName { get; set; }

        [MaxLength(MaxSubjectLength)]
        [Required(ErrorMessage = "Please provide subject to the report.")]
        public string Subject { get; set; }

        [MaxLength(MaxDescriptionLength)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide description to the report.")]
        public string ReportDescription { get; set; }

        public string ReportingUserId { get; set; }
    }
}

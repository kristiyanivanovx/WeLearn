using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.ViewModels.Interfaces;
using static WeLearn.Data.DataValidation.Report;

namespace WeLearn.ViewModels
{
    public class CommentReportModel : IReportModel
    {
        public int OriginId { get; set; }

        public int? ReportId { get; set; }

        public string OriginApplicationUserUserName { get; set; }

        public string CommentContent { get; set; }

        public DateTime CommentDateCreated { get; set; }

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

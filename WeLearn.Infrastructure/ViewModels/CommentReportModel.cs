using System.ComponentModel.DataAnnotations;
using WeLearn.Infrastructure.Interfaces;

namespace WeLearn.Infrastructure.ViewModels
{
    public class CommentReportModel : IReportModel
    {
        public int OriginId { get; set; }

        public int? ReportId { get; set; }

        public string OriginApplicationUserUserName { get; set; }

        public string CommentContent { get; set; }

        public string CreatedByUserName { get; set; }

        [MaxLength(250)]
        [Required(ErrorMessage = "Please provide subject to the report.")]
        public string Subject { get; set; }

        [MaxLength(2000)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide description to the report.")]
        public string ReportDescription { get; set; }

        public string ReportingUserId { get; set; }
    }
}

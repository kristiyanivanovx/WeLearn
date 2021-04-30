using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;
using WeLearn.Infrastructure.Interfaces;

namespace WeLearn.Infrastructure.ViewModels
{
    public class PostReportModel : IReportModel
    {
        public int PostId { get; set; }

        public int? ReportId { get; set; }

        public string PostName { get; set; }

        public string PostApplicationUserUserName { get; set; }

        public string Description { get; set; }

        public Grade Grade { get; set; }

        public string CategoryName { get; set; }


        public string CreatedByUserName { get; set; }

        public string VideoName { get; set; }

        public string VideoLink { get; set; }

        public string ZippedFile { get; set; }

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

using System;
using System.ComponentModel.DataAnnotations;

using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Report;

namespace WeLearn.Web.ViewModels.Admin.Report
{
    public class AdminReportDeleteModel : IMapFrom<Data.Models.Report>
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide subject.")]
        [MaxLength(MaxSubjectLength)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please provide description.")]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public string ApplicationUserId { get; set; }

        public string ApplicationUserUserName { get; set; }

        public string ApplicationUserEmail { get; set; }

        public int? LessonId { get; set; }

        public string LessonName { get; set; }

        public string LessonDescription { get; set; }

        public int? CommentId { get; set; }

        public string CommentContent { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }
    }
}

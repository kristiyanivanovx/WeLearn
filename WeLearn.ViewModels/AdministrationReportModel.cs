using System;
using System.ComponentModel.DataAnnotations;
using static WeLearn.Data.DataValidation.Report;

namespace WeLearn.ViewModels
{
    public class AdministrationReportModel
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
        public DateTime DateCreated { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }
    }
}

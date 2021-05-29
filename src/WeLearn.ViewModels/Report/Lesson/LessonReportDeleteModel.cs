using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;
using WeLearn.ViewModels.Interfaces;
using static WeLearn.Data.Infrastructure.DataValidation.Report;

namespace WeLearn.ViewModels.Report.Lesson
{
    public class LessonReportDeleteModel
    {
        public int LessonId { get; set; }

        public int ReportId { get; set; }

        public string LessonName { get; set; }

        public DateTime DateCreated { get; set; }

        public string LessonApplicationUserUserName { get; set; }

        public string LessonDescription { get; set; }

        public Grade LessonGrade { get; set; }

        public string LessonCategoryName { get; set; }

        public string CreatedByUserName { get; set; }

        public DateTime LessonDateCreated { get; set; }

        public string LessonVideoName { get; set; }

        public string LessonVideoLink { get; set; }

        public string VideoContentType { get; set; }

        public string LessonMaterialLink { get; set; }

        [Required(ErrorMessage = "Please provide subject to the report.")]
        [MaxLength(MaxSubjectLength)]
        public string Subject { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide description to the report.")]
        [MaxLength(MaxDescriptionLength)]
        public string ReportDescription { get; set; }

        public string ApplicationUserId { get; set; }
    }
}

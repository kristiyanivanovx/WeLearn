using System;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Models.Enums;

namespace WeLearn.ViewModels.Lesson
{
    public class LessonSendEmailViewModel
    {
        public int LessonId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Grade Grade { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }

        public string CategoryName { get; set; }

        public string ApplicationUserUserName { get; set; }

        public string VideoName { get; set; }

        public string VideoContentType { get; set; }

        public string VideoLink { get; set; }

        public string MaterialLink { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Your email")]
        public string Email { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;

namespace WeLearn.ViewModels.Lesson
{
    public class LessonDeleteModel
    {
        public int LessonId { get; set; }

        [Display(Name = "Name")]
        public string LessonName { get; set; }

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
    }
}
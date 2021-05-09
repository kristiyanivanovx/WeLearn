using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Interfaces;
using static WeLearn.Data.DataValidation.Comment;

namespace WeLearn.Data.Models
{
    public class Comment : SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(MaxContentLength)]
        public string Content { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Common.Models;
using static WeLearn.Data.Common.Validation.DataValidation.Comment;

namespace WeLearn.Data.Models
{
    public class Comment : BaseDeletableModel<int> //SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(MaxContentLength)]
        public string Content { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        // [Display(Name = "Date created")]
        // public DateTime DateCreated { get; set; }
    }
}

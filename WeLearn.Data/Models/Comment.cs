using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Models
{
    public class Comment : SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}

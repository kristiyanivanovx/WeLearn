using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Models
{
    public class Report : SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(250)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int? LessonId { get; set; }

        public Lesson Lesson { get; set; }

        public int? CommentId { get; set; }

        public Comment Comment { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}

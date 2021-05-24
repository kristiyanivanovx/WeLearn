using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;
using static WeLearn.Data.DataValidation.Video;

namespace WeLearn.Data.Models
{
    public class Video : SoftDeleteable, IMetadataHaveable
    {
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        public string ContentType { get; set; }

        [Required]
        [MaxLength(MaxLinkLength)]
        public string Link { get; set; }

        public string PublicId { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;

using static WeLearn.Data.Common.Validation.DataValidation.Material;

namespace WeLearn.Data.Models
{
    public class Material : BaseDeletableModel<int> // SoftDeletable, IMetadataHavable
    {
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxLinkLength)]
        public string Link { get; set; }

        public string PublicId { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        // [Display(Name = "Date created")]
        // public DateTime DateCreated { get; set; }
    }
}

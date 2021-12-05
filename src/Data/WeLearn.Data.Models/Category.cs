using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;

using static WeLearn.Data.Common.Validation.DataValidation.Category;

namespace WeLearn.Data.Models
{
    public class Category : BaseDeletableModel<int> // SoftDeletable, IMetadataHavable
    {
        public Category()
        {
            this.Lessons = new HashSet<Lesson>();
        }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        // [Display(Name = "Date created")]
        // public DateTime DateCreated { get; set; }
    }
}

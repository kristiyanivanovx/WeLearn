using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;
using static WeLearn.Data.DataValidation.Category;

namespace WeLearn.Data.Models
{
    public class Category : SoftDeleteable, IMetadataHaveable
    {
        public Category()
        {
            this.Lessons = new HashSet<Lesson>();
        }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Interfaces;
namespace WeLearn.Data.Models
{
    public class Category : SoftDeleteable, IMetadataHaveable
    {
        public Category()
        {
            this.Lessons = new HashSet<Lesson>();
        }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}

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
            this.Quizzes = new HashSet<Quiz>();
        }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<Quiz> Quizzes { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.LessonModule;

using static WeLearn.Data.Common.Validation.DataValidation.Category;

namespace WeLearn.Data.Models.Shared
{
    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Lessons = new HashSet<Lesson>();
            this.Quizzes = new HashSet<Quiz.Quiz>();
        }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<Quiz.Quiz> Quizzes { get; set; }
    }
}

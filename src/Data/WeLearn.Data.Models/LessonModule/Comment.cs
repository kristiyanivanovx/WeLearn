using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;

using static WeLearn.Data.Common.Validation.DataValidation.Comment;

namespace WeLearn.Data.Models.LessonModule
{
    public class Comment : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(MaxContentLength)]
        public string Content { get; set; }

        public string UserId { get; set; }

        public Identity.ApplicationUser User { get; set; }

        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.Identity;

using static WeLearn.Data.Common.Validation.DataValidation.Report;

namespace WeLearn.Data.Models.LessonModule
{
    public class Report : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(MaxSubjectLength)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int? LessonId { get; set; }

        public Lesson Lesson { get; set; }

        public int? CommentId { get; set; }

        public Comment Comment { get; set; }
    }
}

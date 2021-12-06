using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models
{
    public class Like : BaseDeletableModel<int>
    {
        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}

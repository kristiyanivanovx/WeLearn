using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.Identity;

namespace WeLearn.Data.Models.LessonModule
{
    public class Recommendation : BaseDeletableModel<int>
    {
        [Required]
        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public float Score { get; set; }
    }
}

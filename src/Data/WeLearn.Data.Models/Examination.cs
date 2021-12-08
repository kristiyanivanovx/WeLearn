using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models
{
    public class Examination : BaseDeletableModel<int>
    {
        [Required]
        public int Points { get; set; }

        [Required]
        public int QuizId { get; set; }

        public Quiz Quiz { get; set; }

        [Required]
        public int ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}

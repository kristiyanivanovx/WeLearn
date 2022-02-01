using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.Identity;

namespace WeLearn.Data.Models.Quiz
{
    public class Examination : BaseDeletableModel<int>
    {
        public Examination()
        {
            this.Choices = new HashSet<Choice>();
        }

        [Required]
        public int Points { get; set; }

        [Required]
        public int QuizId { get; set; }

        public Quiz Quiz { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public ICollection<Choice> Choices { get; set; }
    }
}

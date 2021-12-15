using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models.Quiz
{
    public class Choice : BaseDeletableModel<int>
    {
        [Required]
        public int QuestionId { get; set; }

        public Question Question { get; set; }

        [Required]
        public int UserAnswerId { get; set; }

        public Answer UserAnswer { get; set; }
    }
}

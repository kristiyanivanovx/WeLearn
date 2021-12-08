using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models
{
    public class Answer : BaseDeletableModel<int>
    {
        [Required]
        public bool IsCorrect { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}

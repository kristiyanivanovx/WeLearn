using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models.Quiz
{
    public class Question : BaseDeletableModel<int>
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
            this.Quizzes = new HashSet<Quiz>();
        }

        [Required]
        public string Content { get; set; }

        [Required]
        public int Points { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public ICollection<Quiz> Quizzes { get; set; }
    }
}

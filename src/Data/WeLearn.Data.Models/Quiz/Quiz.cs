using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.Shared;

namespace WeLearn.Data.Models.Quiz
{
    public class Quiz : BaseDeletableModel<int>
    {
        public Quiz()
        {
            this.Questions = new HashSet<Question>();
        }

        [Required]
        public string Name { get; set; }

        public int MaxPoints => this.Questions
            .Sum(q => q.Answers.Where(a => a.QuestionId == q.Id)
                .Sum(a => a.Question.Points));

        // public int MaxPoints => this.Questions
        //     .ToList()
        //     .Sum(q => q.Answers.Where(a => a.IsCorrect && a.QuestionId == q.Id)
        //         .Sum(a => a.Question.Points));
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}

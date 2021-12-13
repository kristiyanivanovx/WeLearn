using System;
using System.ComponentModel.DataAnnotations;

using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Answer
{
    public class AnswerViewModel : IMapFrom<Data.Models.Quiz.Answer>
    {
        public int Id { get; set; }

        [Display(Name = "Is Correct")]
        public bool IsCorrect { get; set; }

        public string Content { get; set; }

        public int QuestionId { get; set; }

        // public Data.Models.Question Question { get; set; }

        public string QuestionContent { get; set; }

        public int QuestionPoints { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}

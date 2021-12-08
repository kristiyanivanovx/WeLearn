using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Answer;
using WeLearn.Web.ViewModels.Quiz;

namespace WeLearn.Web.ViewModels.Question
{
    public class QuestionViewModel : IMapFrom<Data.Models.Question>
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int Points { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public ICollection<AnswerViewModel> Answers { get; set; }

        public ICollection<QuizViewModel> Quizzes { get; set; }
    }
}

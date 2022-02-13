using System.ComponentModel.DataAnnotations;

using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Question
{
    public class QuestionEditModel : IMapTo<Data.Models.Quiz.Question>, IMapFrom<Data.Models.Quiz.Question>
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [Range(1, 10)]
        public int Points { get; set; }

        // public ICollection<AnswerViewModel> Answers { get; set; }
        // public ICollection<QuizViewModel> Quizzes { get; set; }
    }
}

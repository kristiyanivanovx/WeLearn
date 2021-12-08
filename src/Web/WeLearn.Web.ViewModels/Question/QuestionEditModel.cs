using System.ComponentModel.DataAnnotations;

using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Question
{
    public class QuestionEditModel : IMapTo<Data.Models.Question>, IMapFrom<Data.Models.Question>
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int Points { get; set; }

        // public ICollection<AnswerViewModel> Answers { get; set; }
        //
        // public ICollection<QuizViewModel> Quizzes { get; set; }
    }
}

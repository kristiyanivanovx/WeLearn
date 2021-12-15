using WeLearn.Data.Models.Quiz;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Answer;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.ViewModels.Choices
{
    public class ChoiceViewModel : IMapFrom<Choice>
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public QuestionViewModel Question { get; set; }

        public int UserAnswerId { get; set; }

        public AnswerViewModel UserAnswer { get; set; }
    }
}

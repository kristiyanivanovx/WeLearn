using System;
using System.Collections.Generic;

using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Choices;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.ViewModels.Examination
{
    public class ExaminationViewModel : IMapFrom<Data.Models.Quiz.Examination>
    {
        public int Id { get; set; }

        public int Points { get; set; }

        public int QuizId { get; set; }

        public string QuizName { get; set; }

        public string QuizCategoryName { get; set; }

        public int QuizMaxPoints { get; set; }

        public string ApplicationUserId { get; set; }

        public DateTime CreatedOn { get; set; }

        public IEnumerable<QuestionViewModel> Questions { get; set; } = new HashSet<QuestionViewModel>();

        public IEnumerable<ChoiceViewModel> Choices { get; set; } = new HashSet<ChoiceViewModel>();
    }
}

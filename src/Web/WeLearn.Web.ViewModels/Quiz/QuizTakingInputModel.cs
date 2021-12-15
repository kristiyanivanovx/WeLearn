using System;
using System.Collections.Generic;

using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.ViewModels.Quiz
{
    public class QuizTakingInputModel : IMapFrom<Data.Models.Quiz.Quiz>
    {
        public QuizTakingInputModel()
        {
            this.Questions = new HashSet<QuestionTakingInputModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public int MaxPoints { get; set; }

        public string CategoryName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public ICollection<QuestionTakingInputModel> Questions { get; set; }
    }
}

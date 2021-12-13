using System;
using WeLearn.Services.Mapping;

namespace WeLearn.Web.ViewModels.Examination
{
    public class ExaminationViewModel : IMapFrom<Data.Models.Quiz.Examination>
    {
        public int Id { get; set; }

        public int Points { get; set; }

        public int QuizId { get; set; }

        public string QuizName { get; set; }
        
        public string QuizCategoryName { get; set; }
        
        public string QuizMaxPoints { get; set; }

        public string ApplicationUserId { get; set; }
        
        public DateTime CreatedOn { get; set; }
    }
}
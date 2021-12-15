using System;
using System.Collections.Generic;

using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.ViewModels.Quiz
{
    public class QuizViewModel : IMapFrom<Data.Models.Quiz.Quiz>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public int MaxPoints { get; set; }

        public string CategoryName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public ICollection<QuestionViewModel> Questions { get; set; }

        // public void CreateMappings(IProfileExpression configuration)
        // {
        //     configuration.CreateMap<Data.Models.Quiz, QuizViewModel>()
        //         .ForMember(
        //             dest => dest.MaxPoints,
        //             opt => opt.MapFrom(
        //                 src => src.Questions
        //                     .ToList()
        //                     .Sum(q => q.Answers.Where(a => a.IsCorrect && a.QuestionId == q.Id)
        //                         .Sum(a => a.Question.Points))));
        // }
    }
}

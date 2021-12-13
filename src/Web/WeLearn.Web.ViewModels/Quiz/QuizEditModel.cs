using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AutoMapper;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.ViewModels.Quiz
{
    public class QuizEditModel : IMapTo<Data.Models.Quiz.Quiz>, IMapFrom<Data.Models.Quiz.Quiz>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please pick a category.")]
        public int CategoryId { get; set; }

        public IEnumerable<int> QuestionIds { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public ICollection<QuestionViewModel> Questions { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<Data.Models.Quiz.Quiz, QuizEditModel>()
                    .ForMember(
                        dest => dest.QuestionIds,
                        opt => opt.MapFrom(
                            src => src.Questions.Select(x => x.Id)));
        }
    }
}

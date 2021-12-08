using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Category;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.ViewModels.Quiz
{
    public class QuizEditModel : IMapTo<Data.Models.Quiz>, IMapFrom<Data.Models.Quiz>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please pick a category.")]
        public int CategoryId { get; set; }

        public IEnumerable<int> QuestionIds { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public ICollection<QuestionViewModel> Questions { get; set; }
    }
}

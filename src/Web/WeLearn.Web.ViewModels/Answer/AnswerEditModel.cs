using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Question;

namespace WeLearn.Web.ViewModels.Answer
{
    public class AnswerEditModel : IMapTo<Data.Models.Answer>, IMapFrom<Data.Models.Answer>
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Is correct")]
        public bool IsCorrect { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Question")]
        public int QuestionId { get; set; }

        public IEnumerable<QuestionViewModel> Questions { get; set; }
    }
}

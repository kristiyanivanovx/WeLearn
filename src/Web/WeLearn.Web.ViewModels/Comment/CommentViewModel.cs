using System;
using System.ComponentModel.DataAnnotations;

using Ganss.XSS;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Comment;

namespace WeLearn.Web.ViewModels.Comment
{
    public class CommentViewModel : IMapFrom<Data.Models.LessonModule.Comment>
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int LessonId { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(MaxContentLength, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public string UserUserName { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}

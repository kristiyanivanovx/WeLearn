using System;
using System.ComponentModel.DataAnnotations;

using Ganss.XSS;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Mapping;

using static WeLearn.Data.Common.Validation.DataValidation.Comment;

namespace WeLearn.Web.ViewModels.Comment
{
    public class CommentEditModel : IMapFrom<Data.Models.LessonModule.Comment>
    {
        public int Id { get; set; }

        public int LessonId { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(MaxContentLength, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public int LessonLikesCount { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public DateTime LessonCreatedOn { get; set; }

        public string LessonName { get; set; }

        public string LessonDescription { get; set; }

        public Grade LessonGrade { get; set; }

        public string LessonCategoryName { get; set; }

        public string LessonVideoLink { get; set; }

        public string LessonVideoName { get; set; }

        public string LessonVideoContentType { get; set; }

        public string LessonMaterialLink { get; set; }

        public string LessonApplicationUserUserName { get; set; }
    }
}

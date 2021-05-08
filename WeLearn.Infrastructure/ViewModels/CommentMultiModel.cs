using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;
using static WeLearn.Data.DataValidation.Comment;

namespace WeLearn.Infrastructure.ViewModels
{
    public class CommentMultiModel
    {
        public int CommentId { get; set; }

        public int LessonId { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(MaxContentLength, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string Content { get; set; }

        public string ApplicationUserId { get; set; }

        public string LessonName { get; set; }

        public string LessonDescription { get; set; }

        public Grade LessonGrade { get; set; }

        public string LessonCategoryName { get; set; }

        public string LessonVideoLink { get; set; }

        public string LessonVideoName { get; set; }

        public string LessonVideoContentType { get; set; }

        public string LessonZippedFileLink { get; set; }

        public string LessonCreatedByUsername { get; set; }
    }
}

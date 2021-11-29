using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;
using static WeLearn.Data.Infrastructure.DataValidation.Comment;

namespace WeLearn.ViewModels.Admin.Comment
{
    public class AdminCommentEditModel
    {
        public int Id { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(MaxContentLength, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string Content { get; set; }

        public string ApplicationUserUserName { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }

        public DateTime LessonDateCreated { get; set; }

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

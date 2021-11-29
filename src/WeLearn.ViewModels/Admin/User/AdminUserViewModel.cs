using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Enums;
using static WeLearn.Data.Infrastructure.DataValidation.Comment;

namespace WeLearn.ViewModels.Admin.Comment
{
    public class AdminUserViewModel
    {
        public string ApplicationUserUserName { get; set; }

        public string ApplicationUserEmail { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }

        public int CommentId { get; set; }

        public int LessonId { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(MaxContentLength, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string Content { get; set; }

        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }

        public string ApplicationUserId { get; set; }

        public DateTime LessonDateCreated { get; set; }
    }
}

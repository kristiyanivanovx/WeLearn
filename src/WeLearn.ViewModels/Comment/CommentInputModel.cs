using System;
using System.ComponentModel.DataAnnotations;
using static WeLearn.Data.DataValidation.Comment;

namespace WeLearn.ViewModels.Comment
{
    public class CommentInputModel
    {
        public int CommentId { get; set; }

        public int LessonId { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(MaxContentLength, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string Content { get; set; }

        public string ApplicationUserUserName { get; set; }

        public DateTime DateCreated { get; set; }
        
        public string ApplicationUserId { get; set; }
    }
}

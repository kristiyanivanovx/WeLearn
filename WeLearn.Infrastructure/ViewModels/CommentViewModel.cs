using System;
using System.ComponentModel.DataAnnotations;

namespace WeLearn.Infrastructure.ViewModels
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(1000, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string CommentContent { get; set; }

        public string UserName { get; set; }

        public DateTime DateCreated { get; set; }
        
        public string ApplicationUserId { get; set; }
    }
}

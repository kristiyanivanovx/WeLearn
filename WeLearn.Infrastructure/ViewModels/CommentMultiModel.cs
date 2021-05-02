using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Enums;

namespace WeLearn.Infrastructure.ViewModels
{
    public class CommentMultiModel
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        [MaxLength(1000, ErrorMessage = "Please, provide content between 0 and 1000 characters.")]
        public string Content { get; set; }

        public string ApplicationUserId { get; set; }

        public string PostName { get; set; }

        public string PostDescription { get; set; }

        public Grade PostGrade { get; set; }

        public string PostCategoryName { get; set; }

        public string PostVideoLink { get; set; }

        public string PostVideoName { get; set; }

        public string PostVideoContentType { get; set; }

        public string PostZippedFileLink { get; set; }

        public string PostCreatedByUsername { get; set; }
    }
}

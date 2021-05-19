using System;
using System.ComponentModel.DataAnnotations;

namespace WeLearn.ViewModels
{
    public class AdministrationCommentModel : CommentMultiModel
    {
        public string ApplicationUserUserName { get; set; }

        public string ApplicationUserEmail { get; set; }

        [Display(Name = "Is deleted")]
        public bool IsDeleted { get; set; }

        public string LessonMaterialLink { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace WeLearn.Web.ViewModels.Message
{
    public class PrivateMessageInputModel
    {
        [Required]
        [MaxLength(1500)]
        public string Text { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string ReceiverUsername { get; set; }

        public string ReceiverUsernameErrorMessage { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}

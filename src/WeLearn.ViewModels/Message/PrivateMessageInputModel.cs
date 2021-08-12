using System;
using System.ComponentModel.DataAnnotations;

namespace WeLearn.ViewModels.Message
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

        public DateTime DateCreated { get; set; }
    }
}

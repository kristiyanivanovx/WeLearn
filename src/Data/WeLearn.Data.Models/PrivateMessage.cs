using System;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Common.Models;

using static WeLearn.Data.Common.Validation.DataValidation.PrivateMessage;

namespace WeLearn.Data.Models
{
    public class PrivateMessage : BaseDeletableModel<int> //Identifiable, IMetadataHaveable
    {
        [Required]
        [MaxLength(MaxMessageLength)]
        public string Text { get; set; }

        public string SenderId { get; set; }

        public ApplicationUser Sender { get; set; }

        public string ReceiverId { get; set; }

        public ApplicationUser Receiver { get; set; }
    }
}

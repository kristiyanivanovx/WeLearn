using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data.Models.Base;

namespace WeLearn.Data.Models
{
    public class PrivateMessage : Identifiable, IMetadataHaveable
    {
        [Required]
        [MaxLength(1500)]
        public string Text { get; set; }

        public DateTime DateCreated { get; set; }

        public string SenderId { get; set; }

        public ApplicationUser Sender { get; set; }

        public string ReceiverId { get; set; }

        public ApplicationUser Receiver { get; set; }
    }
}

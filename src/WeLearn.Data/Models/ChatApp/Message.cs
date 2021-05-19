using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeLearn.Data.Models.Base;

namespace WeLearn.Data.Models.ChatApp
{
    public class Message : Identifiable, IMetadataHaveable
    {
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Text { get; set; }

        public DateTime DateCreated { get; set; }

        public int ChatId { get; set; }

        public Chat Chat { get; set; }
    }
}

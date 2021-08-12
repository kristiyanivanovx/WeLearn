using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Models.Base;

namespace WeLearn.Data.Models.ChatApp
{
    public class Chat : Identifiable, IMetadataHaveable
    {
        public Chat()
        {
            this.Messages = new HashSet<Message>();
            this.ChatApplicationUsers = new HashSet<ChatApplicationUser>();
        }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Message> Messages { get; set; }
        
        public ICollection<ChatApplicationUser> ChatApplicationUsers { get; set; }

        public DateTime DateCreated { get; set;  }
    }
}

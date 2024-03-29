﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models.ChatApp
{
    public class Chat : BaseModel<int>
    {
        public Chat()
        {
            this.Messages = new HashSet<Message>();
            this.ChatUsers = new HashSet<ChatUser>();
        }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Message> Messages { get; set; }

        public ICollection<ChatUser> ChatUsers { get; set; }
    }
}

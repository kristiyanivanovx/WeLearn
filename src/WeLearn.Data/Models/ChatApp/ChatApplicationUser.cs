using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLearn.Data.Models.ChatApp
{
    public class ChatApplicationUser
    {
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int ChatId { get; set; }

        public Chat Chat { get; set; }

        public ChatApplicationUserRole Role { get; set; }
    }
}

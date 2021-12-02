using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Models.ChatApp;

namespace WeLearn.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.SentPrivateMessages = new HashSet<PrivateMessage>();
            this.ReceivedPrivateMessages = new HashSet<PrivateMessage>();
            this.Lessons = new HashSet<Lesson>();
            this.Comments = new HashSet<Comment>();
            this.Reports = new HashSet<Report>();
            this.Chats = new HashSet<ChatApplicationUser>();
        }

        public ICollection<PrivateMessage> SentPrivateMessages { get; set; }

        public ICollection<PrivateMessage> ReceivedPrivateMessages { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Report> Reports { get; set; }

        public ICollection<ChatApplicationUser> Chats { get; set; }
    }
}

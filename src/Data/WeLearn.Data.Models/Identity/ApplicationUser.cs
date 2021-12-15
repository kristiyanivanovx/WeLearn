using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Models.LessonModule;

namespace WeLearn.Data.Models.Identity
{
    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();

            // this.SentPrivateMessages = new HashSet<PrivateMessage>();
            // this.ReceivedPrivateMessages = new HashSet<PrivateMessage>();
            this.Likes = new HashSet<Like>();
            this.Lessons = new HashSet<Lesson>();
            this.Comments = new HashSet<Comment>();
            this.Reports = new HashSet<Report>();
            this.Chats = new HashSet<ChatApplicationUser>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        // public ICollection<PrivateMessage> SentPrivateMessages { get; set; }

        // public ICollection<PrivateMessage> ReceivedPrivateMessages { get; set; }
        public ICollection<Like> Likes { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Report> Reports { get; set; }

        public ICollection<ChatApplicationUser> Chats { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}

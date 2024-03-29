﻿using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Models.LessonModule;
using WeLearn.Data.Models.Quiz;
using WeLearn.Data.Models.User;

namespace WeLearn.Data.Models.Identity
{
    public sealed class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.ApplicationUserRoles = new HashSet<ApplicationUserRole>();
            this.Examinations = new HashSet<Examination>();
            this.Recommendations = new HashSet<LessonModule.Recommendation>();
            this.Likes = new HashSet<Like>();
            this.Lessons = new HashSet<Lesson>();
            this.Comments = new HashSet<Comment>();
            this.Reports = new HashSet<Report>();
            this.Chats = new HashSet<ChatUser>();
            this.Organizations = new HashSet<Organization>();
            this.CreatedOrganizations = new HashSet<Organization>();
        }

        public string ProfileImageUrl { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public IEnumerable<Examination> Examinations { get; set; }

        public IEnumerable<Organization> CreatedOrganizations { get; set; }

        public IEnumerable<Organization> Organizations { get; set; }

        public ICollection<Like> Likes { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Report> Reports { get; set; }

        public ICollection<ChatUser> Chats { get; set; }

        public ICollection<LessonModule.Recommendation> Recommendations { get; set; }

        public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; }

        public ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}

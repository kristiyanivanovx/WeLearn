using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WeLearn.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Lessons = new HashSet<Lesson>();
            this.Comments = new HashSet<Comment>();
            this.Reports = new HashSet<Report>();
        }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}

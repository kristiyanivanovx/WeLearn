using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WeLearn.Data.Common.Models;
using WeLearn.Data.Models.Identity;

namespace WeLearn.Data.Models.User
{
    public class Organization : BaseDeletableModel<int>
    {
        public Organization()
        {
            this.ApplicationUsers = new HashSet<ApplicationUser>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; }

        public string CreatorId { get; set; }

        public ApplicationUser Creator { get; set; }
    }
}
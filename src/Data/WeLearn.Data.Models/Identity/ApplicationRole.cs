using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Common.Models;

namespace WeLearn.Data.Models.Identity
{
    public sealed class ApplicationRole : IdentityRole, IAuditInfo, IDeletableEntity
    {
        public ApplicationRole()
           : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
            this.ApplicationUserRoles = new HashSet<ApplicationUserRole>();
        }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; }
    }
}

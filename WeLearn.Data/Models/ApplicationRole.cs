using System;
using Microsoft.AspNetCore.Identity;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base () { }

        public ApplicationRole(string roleName) : base (roleName) { }
    }
}

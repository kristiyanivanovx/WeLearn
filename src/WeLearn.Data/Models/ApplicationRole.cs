using Microsoft.AspNetCore.Identity;

namespace WeLearn.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base () { }

        public ApplicationRole(string roleName) : base (roleName) { }
    }
}

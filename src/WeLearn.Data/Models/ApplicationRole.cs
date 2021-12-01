using Microsoft.AspNetCore.Identity;

namespace WeLearn.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName)
            : base(roleName)
        {
        }
    }
}

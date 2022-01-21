using Microsoft.AspNetCore.Identity;

namespace WeLearn.Data.Models.Identity
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }

        public virtual ApplicationRole Role { get; set; }
    }
}

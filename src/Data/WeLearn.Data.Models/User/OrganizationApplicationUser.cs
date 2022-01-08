using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Models.Identity;

namespace WeLearn.Data.Models.User
{
    public class OrganizationApplicationUser
    {
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int OrganizationId { get; set; }

        public WeLearn.Data.Models.User.Organization Organization { get; set; }
    }
}
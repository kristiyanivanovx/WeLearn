using WeLearn.Data.Models.Identity;

namespace WeLearn.Data.Models.User
{
    public class OrganizationUser
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }
    }
}

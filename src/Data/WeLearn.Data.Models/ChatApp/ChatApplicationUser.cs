using WeLearn.Data.Models.Identity;

namespace WeLearn.Data.Models.ChatApp
{
    public class ChatApplicationUser
    {
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public int ChatId { get; set; }

        public Chat Chat { get; set; }
    }
}

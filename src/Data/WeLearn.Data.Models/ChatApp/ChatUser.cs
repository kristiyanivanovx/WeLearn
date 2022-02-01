using WeLearn.Data.Models.Identity;

namespace WeLearn.Data.Models.ChatApp
{
    public class ChatUser
    {
        public int ChatId { get; set; }

        public Chat Chat { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}

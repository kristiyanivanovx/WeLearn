using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeLearn.Data.Models.ChatApp;

namespace WeLearn.Data.Configurations
{
    public class ChatApplicationUserConfiguration : IEntityTypeConfiguration<ChatApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ChatApplicationUser> chatAppUser)
        {
            chatAppUser
                .HasKey(x => new { x.ChatId, x.ApplicationUserId });
        }
    }
}

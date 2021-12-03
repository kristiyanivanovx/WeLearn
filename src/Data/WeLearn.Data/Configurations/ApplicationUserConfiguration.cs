using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeLearn.Data.Models;

namespace WeLearn.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> appUser)
        {
            appUser
                .HasMany(e => e.Claims)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            appUser
                .HasMany(e => e.Logins)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            appUser
                .HasMany(e => e.Roles)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // do not cascade delete the lessons on user delete, just set their owner to null
            appUser
                .HasMany(x => x.Lessons)
                .WithOne(x => x.ApplicationUser)
                .OnDelete(DeleteBehavior.SetNull);

            // do not cascade delete the reports on user delete, just set their owner to null
            appUser
                .HasMany(x => x.Reports)
                .WithOne(x => x.ApplicationUser)
                .OnDelete(DeleteBehavior.SetNull);

            // cascade delete the comments on user delete
            appUser
                .HasMany(x => x.Comments)
                .WithOne(x => x.ApplicationUser)
                .OnDelete(DeleteBehavior.Cascade);
                // .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

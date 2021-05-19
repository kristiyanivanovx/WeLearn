using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Models;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Seed;

namespace WeLearn.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

            modelBuilder.Entity<ChatApplicationUser>()
                .HasKey(x => new { x.ChatId, x.ApplicationUserId });

            // do not cascade delete the lessons on user delete, just set their owner to null
            modelBuilder.Entity<ApplicationUser>()
                 .HasMany(x => x.Lessons)
                 .WithOne(x => x.ApplicationUser)
                 .OnDelete(DeleteBehavior.SetNull);

            // do not cascade delete the reports on user delete, just set their owner to null
            modelBuilder.Entity<ApplicationUser>()
               .HasMany(x => x.Reports)
               .WithOne(x => x.ApplicationUser)
               .OnDelete(DeleteBehavior.SetNull);

            // cascade delete the comments on user delete
            modelBuilder.Entity<ApplicationUser>()
                 .HasMany(x => x.Comments)
                 .WithOne(x => x.ApplicationUser)
                 .OnDelete(DeleteBehavior.Cascade);

            // rules for deleting a report in administration
            modelBuilder.Entity<Report>()
               .HasOne(x => x.Lesson)
               .WithMany()
               .OnDelete(DeleteBehavior.Cascade);

            // rules for deleting a report in administration
            modelBuilder.Entity<Report>()
               .HasOne(x => x.Comment)
               .WithMany()
               .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<ChatApplicationUser> ChatApplicationUsers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Material> Materials { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<Report> Reports { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}

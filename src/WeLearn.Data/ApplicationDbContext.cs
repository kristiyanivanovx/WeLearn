using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Models;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Infrastructure;

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
            modelBuilder.ConfigureRelations();
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

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

		public ApplicationDbContext()
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.ConfigureRelations();
        }

        public virtual DbSet<Chat> Chats { get; set; }

        public virtual DbSet<Message> Messages { get; set; }

        public virtual DbSet<ChatApplicationUser> ChatApplicationUsers { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Comment> Comments { get; set; }

        public virtual DbSet<Material> Materials { get; set; }

        public virtual DbSet<Lesson> Lessons { get; set; }

        public virtual DbSet<Video> Videos { get; set; }

        public virtual DbSet<Report> Reports { get; set; }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}

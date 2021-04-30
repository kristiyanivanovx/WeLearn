using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeLearn.Data.Models;
using WeLearn.Data.Seed;

namespace WeLearn.Data.Context
{
    //public class ApplicationDbContext : IdentityDbContext
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=WeLearn;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            //modelBuilder.Entity<Post>()
            //   .HasOne(x => x.User)
            //   .WithMany(x => x.Posts)
            //   .HasForeignKey(x => x.UserId)
            //   .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Comment>()
            //    .HasOne(x => x.User)
            //    .WithMany(x => x.Comments)
            //    .HasForeignKey(x => x.UserId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Post>()
            //    .HasOne(x => x.Video);
            //.WithOne(x => x.Post)
            //.HasForeignKey<Post>(x => x.PostId);

            //modelBuilder.Entity<Post>()
            //    .HasOne(x => x.Material);
            //.WithOne(x => x.Post)
            //.HasForeignKey<Post>(x => x.PostId);

            modelBuilder.Entity<Post>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Report>().HasQueryFilter(p => !p.IsDeleted);

            base.OnModelCreating(modelBuilder);
        }

         //some random stackoverflow comment
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var AddedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added)
                .ToList();

            AddedEntities.ForEach(e => e.Property("DateCreated").CurrentValue = DateTime.UtcNow);

            var EditedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified)
                .ToList();

            EditedEntities.ForEach(e => e.Property("DateModified").CurrentValue = DateTime.UtcNow);

            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = entry.Entity;

                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entity.GetType().GetProperty("IsDeleted").SetValue(entity, true);
                }
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Material> Materials { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<Report> Reports { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}

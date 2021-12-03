using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeLearn.Data.Models;

namespace WeLearn.Data.Configurations
{
    public class VideoConfiguration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> video)
        {
            video
                .HasOne(x => x.Lesson)
                .WithOne(x => x.Video)
                .HasForeignKey<Video>(x => x.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
                // .OnDelete(DeleteBehavior.Restrict);

            // todo: move in their own config when builds
            // modelBuilder.Entity<Lesson>()
            //    .HasOne(x => x.Material)
            //    .WithOne(x => x.Lesson)
            //    .HasForeignKey<Lesson>(x => x.MaterialId)
            //    .OnDelete(DeleteBehavior.Cascade);

            // modelBuilder.Entity<Lesson>()
            //    .HasOne(x => x.Video)
            //    .WithOne(x => x.Lesson)
            //    .HasForeignKey<Lesson>(x => x.VideoId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeLearn.Data.Models;

namespace WeLearn.Data.Configurations
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> material)
        {
            material
                .HasOne(x => x.Lesson)
                .WithOne(x => x.Material)
                .HasForeignKey<Material>(x => x.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

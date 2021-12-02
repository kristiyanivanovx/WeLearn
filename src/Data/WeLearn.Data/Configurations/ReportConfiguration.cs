using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeLearn.Data.Models;

namespace WeLearn.Data.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> report)
        {
            // rules for deleting a report in administration
            report
                .HasOne(x => x.Lesson)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            // rules for deleting a report in administration
            report
                .HasOne(x => x.Comment)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

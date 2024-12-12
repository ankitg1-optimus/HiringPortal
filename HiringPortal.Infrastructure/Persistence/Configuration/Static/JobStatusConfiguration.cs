using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Static
{
    public class JobStatusConfiguration : IEntityTypeConfiguration<JobStatus>
    {
        public void Configure(EntityTypeBuilder<JobStatus> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasMany<Job>(s=>s.Jobs)
                .WithOne(j=>j.JobStatus)
                .HasForeignKey(j=>j.JobStatusId);
        }
    }
}

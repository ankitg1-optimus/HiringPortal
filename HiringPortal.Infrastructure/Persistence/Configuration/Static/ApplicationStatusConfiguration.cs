using HiringPortal.Domain.Entities.UseCase;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Static
{
    public class ApplicationStatusConfiguration : IEntityTypeConfiguration<ApplicationStatus>
    {
        public void Configure(EntityTypeBuilder<ApplicationStatus> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasMany<JobApplication>(a=>a.JobApplications).WithOne(ja=>ja.Status).HasForeignKey(ja=>ja.StatusId);
        }
    }
}

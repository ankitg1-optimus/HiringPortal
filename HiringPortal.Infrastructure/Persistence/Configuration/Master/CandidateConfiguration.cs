using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.UseCase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Master
{
    internal class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany<JobApplication>(c=>c.JobApplications).WithOne(ja=>ja.Candidate).HasForeignKey(c=>c.CandidateId);

            builder.HasMany<Skill>(c => c.Skills).WithMany(s => s.Candidates);
        }
    }
}

using HiringPortal.Domain.Entities.UseCase;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Infrastructure.Persistence.Configuration.UseCase
{
    public class InterviewConfiguration : IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.HasKey(i => i.Id);

            builder.HasOne<Stage>(i=>i.Stage)
                .WithMany(s=>s.Interviews)
                .HasForeignKey(i=>i.StageId);

            builder.HasOne<InterviewStatus>(i => i.InterviewStatus)
                .WithMany(s=>s.Interviews)
                .HasForeignKey(i=>i.InterviewStatusId);

            builder.HasOne<JobApplication>(i=>i.JobApplication)
                .WithMany(ja=>ja.Interviews)
                .HasForeignKey(i=>i.JobApplicationId);
        }
    }
}

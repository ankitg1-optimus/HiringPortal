using HiringPortal.Domain.Entities.UseCase;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Static
{
    public class InterviewStatusConfiguration : IEntityTypeConfiguration<InterviewStatus>
    {
        public void Configure(EntityTypeBuilder<InterviewStatus> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany<Interview>(s=>s.Interviews)
                .WithOne(i=>i.InterviewStatus)
                .HasForeignKey(i=>i.InterviewStatusId);
        }
    }
}

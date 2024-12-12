using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Static
{
    public class StageConfiguration : IEntityTypeConfiguration<Stage>
    {
        public void Configure(EntityTypeBuilder<Stage> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasMany<Interview>(s=>s.Interviews)
                .WithOne(i=>i.Stage)
                .HasForeignKey(i=>i.StageId);
        }
    }
}

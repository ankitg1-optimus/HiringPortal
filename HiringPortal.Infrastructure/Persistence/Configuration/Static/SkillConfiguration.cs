using HiringPortal.Domain.Entities.Static;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Static
{
    internal class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasMany(s=>s.Jobs)
                .WithMany(j=>j.Skills);

            builder.HasMany(s=>s.Candidates)
                .WithMany(c=>c.Skills);
        }
    }
}

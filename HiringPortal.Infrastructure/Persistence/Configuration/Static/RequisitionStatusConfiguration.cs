using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Static
{
    public class RequisitionStatusConfiguration : IEntityTypeConfiguration<RequisitionStatus>
    {
        public void Configure(EntityTypeBuilder<RequisitionStatus> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasMany(s=>s.Requisitions)
                .WithOne(r=>r.RequisitionStatus)
                .HasForeignKey(r=>r.RequisitionStatusId);
        }
    }
}

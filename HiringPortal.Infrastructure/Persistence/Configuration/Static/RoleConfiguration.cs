using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Static
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r=>r.Id);

            builder.HasMany<Employee>(r=>r.Employees)
                .WithOne(e=>e.Role)
                .HasForeignKey(e=>e.RoleId);

            builder.HasMany<Requisition>(r => r.Requistions)
                .WithOne(rq => rq.Role)
                .HasForeignKey(rq => rq.RoleId);
        }
    }
}

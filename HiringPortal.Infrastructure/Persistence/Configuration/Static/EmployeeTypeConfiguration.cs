using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Static
{
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<EmployeeType>
    {
        public void Configure(EntityTypeBuilder<EmployeeType> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasMany<Employee>(t=>t.Employees)
                .WithOne(e=>e.EmployeeType)
                .HasForeignKey(e=>e.EmployeeTypeId);

            builder.HasMany<Job>(t => t.Jobs)
                .WithOne(j => j.EmployeeType)
                .HasForeignKey(j => j.EmploymentTypeId);
        }
    }
}

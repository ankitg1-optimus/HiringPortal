using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.UseCase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HiringPortal.Infrastructure.Persistence.Configuration.Master
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e=>e.Id);

            builder.HasOne<Role>(e => e.Role)
                .WithMany(r => r.Employees)
                .HasForeignKey(e=>e.RoleId);

            builder.HasOne<Department>(e=>e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e=>e.DepartmentId);

            builder.HasOne<EmployeeType>(e=>e.EmployeeType)
                .WithMany(t => t.Employees)
                .HasForeignKey(e=>e.EmployeeTypeId);

            builder.HasMany<Requisition>(e=>e.Requisitions)
                .WithOne(r=>r.Employee)
                .HasForeignKey(r=>r.EmployeeId);

            builder.HasMany<Requisition>(e=>e.Reviews)
                .WithOne(r=>r.Reviewer)
                .HasForeignKey(r=>r.ReviewerId);

            builder.HasMany<JobApplication>(e=>e.Referrals)
                .WithOne(ja=>ja.ReferrerEmployee)
                .HasForeignKey(ja=>ja.ReferrerEmployeeId);

            //builder.HasMany<JobApplication>(e=>e.JobApplicationsCreated)
            //    .WithOne(ja=>ja.CreatedBy)
            //    .HasForeignKey(ja=>ja.CreatedById);

            builder.HasMany<Job>(e=>e.JobsCreated)
                .WithOne(j=>j.CreatedBy)
                .HasForeignKey(j=>j.CreatedById);
        }
    }
}

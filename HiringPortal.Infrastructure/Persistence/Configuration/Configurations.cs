using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.UseCase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HiringPortal.Infrastructure.Persistence.Configurations
{
    public class RequisitionConfiguration : IEntityTypeConfiguration<Requisition>
    {
        public void Configure(EntityTypeBuilder<Requisition> builder)
        {
            builder.HasOne<Employee>(r => r.Employee)
                   .WithMany(e => e.Requisitions)
                   .HasForeignKey(r => r.EmployeeId);

            builder.HasOne<Employee>(r => r.Reviewer)
                   .WithMany(e => e.Reviews)
                   .HasForeignKey(r => r.ReviewerId);
        }
    }

    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasOne<Requisition>(j => j.Requisition)
                   .WithOne()
                   .HasForeignKey<Job>(j => j.RequisitionId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(j => j.Requisition)
                   .WithOne(r => r.Job)
                   .HasForeignKey<Job>(j => j.RequisitionId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class JobApplicationConfiguration : IEntityTypeConfiguration<JobApplication>
    {
        public void Configure(EntityTypeBuilder<JobApplication> builder)
        {
            builder.HasOne<Employee>(j => j.ReferrerEmployee)
                   .WithOne(e => e.Referral)
                   .HasForeignKey<JobApplication>(j => j.ReferrerEmployeeId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ja => ja.Job)
                   .WithMany(j => j.JobApplications)
                   .HasForeignKey(j => j.JobId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.UseCase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HiringPortal.Infrastructure.Persistence.Configuration.UseCase
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(j=>j.Id);

            builder.HasOne<Requisition>(j => j.Requisition)
                   .WithOne(r=>r.Job)
                   .HasForeignKey<Job>(j=>j.RequisitionId);

            builder.HasMany<Skill>(j => j.Skills)
                .WithMany(s => s.Jobs);

            builder.HasOne<EmployeeType>(j=>j.EmployeeType)
                .WithMany(t=>t.Jobs)
                .HasForeignKey(j=>j.EmploymentTypeId);

            builder.HasOne<Employee>(j => j.CreatedBy)
                .WithMany(e=>e.JobsCreated)
                .HasForeignKey(j => j.CreatedById);

            builder.HasOne<JobStatus>(j=>j.JobStatus)
                .WithMany(s=>s.Jobs)
                .HasForeignKey(j=>j.JobStatusId);

            builder.HasMany<JobApplication>(j => j.JobApplications)
                .WithOne(ja => ja.Job)
                .HasForeignKey(ja => ja.JobId);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.UseCase;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Infrastructure.Persistence.Configuration.UseCase
{
    public class  JobApplicationConfiguration : IEntityTypeConfiguration<JobApplication>
    {
        public void Configure(EntityTypeBuilder<JobApplication> builder)
        {
            builder.HasKey(ja=>ja.Id);

            builder.HasOne<Job>(ja => ja.Job)
                .WithMany(j=>j.JobApplications)
                .HasForeignKey(ja=>ja.JobId);

            builder.HasOne<Candidate>(ja=>ja.Candidate)
                .WithMany(c=>c.JobApplications)
                .HasForeignKey(j=>j.CandidateId);

            //builder.HasOne<Employee>(ja=>ja.CreatedBy)
            //    .WithMany(e=>e.JobApplicationsCreated)
            //    .HasForeignKey(ja=>ja.CreatedById);

            builder.HasOne<Employee>(ja=>ja.ReferrerEmployee)
                .WithMany(e=>e.Referrals)
                .HasForeignKey(j=>j.ReferrerEmployeeId);

            builder.HasOne<ApplicationStatus>(ja=>ja.Status)
                .WithMany(a=>a.JobApplications)
                .HasForeignKey(ja=>ja.StatusId);

            builder.HasMany<Interview>(ja=>ja.Interviews)
                .WithOne(i=>i.JobApplication)
                .HasForeignKey(i=>i.JobApplicationId);
        }
    }
}

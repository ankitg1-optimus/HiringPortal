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
    public class RequisitionConfiguration : IEntityTypeConfiguration<Requisition>
    {
        public void Configure(EntityTypeBuilder<Requisition> builder)
        {
            builder.HasKey(r => r.Id);

            builder.HasOne<RequisitionStatus>(r=>r.RequisitionStatus)
                .WithMany(s=>s.Requisitions)
                .HasForeignKey(r=>r.RequisitionStatusId);

            builder.HasOne<Department>(r=>r.Department)
                .WithMany(d=>d.Requisitions)
                .HasForeignKey(r => r.DepartmentId);

            builder.HasOne<Role>(rq=>rq.Role)
                .WithMany(r=>r.Requistions)
                .HasForeignKey(rq => rq.RoleId);

            builder.HasOne<Employee>(r => r.Employee)
                .WithMany(e => e.Requisitions)
                .HasForeignKey(r => r.EmployeeId);

            builder.HasOne<Employee>(r => r.Reviewer)
                .WithMany(e => e.Reviews)
                .HasForeignKey(r => r.ReviewerId);

            builder.HasOne<Job>(r => r.Job)
                .WithOne(r => r.Requisition)
                .HasForeignKey<Job>(j => j.RequisitionId);
        }
    }
}

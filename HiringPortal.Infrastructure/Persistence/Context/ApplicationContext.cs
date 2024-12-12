using System.Reflection;
using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.UseCase;
using HiringPortal.Infrastructure.Persistence.Configuration;
using HiringPortal.Infrastructure.Persistence.Configuration.UseCase;
using Microsoft.EntityFrameworkCore;

namespace HiringPortal.Infrastructure.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatus { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<InterviewStatus> InterviewStatus { get; set; }
        public DbSet<JobStatus> JobStatus { get; set; }
        public DbSet<RequisitionStatus> RequisitionStatus { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Stage> Stage { get; set; }
        public DbSet<Interview> Interview { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobApplication> JobApplication { get; set; }
        public DbSet<Requisition> Requisition { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach( var entities in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var fk in entities.GetForeignKeys())
                {
                    fk.DeleteBehavior = DeleteBehavior.Restrict;
                }
            }
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

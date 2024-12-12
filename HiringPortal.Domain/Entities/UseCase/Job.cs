using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Domain.Entities.UseCase
{
    public class Job
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int RequisitionId { get; set; }
        public int CreatedById { get; set; }
        public int YOE { get; set; }
        public int JobStatusId { get; set; }
        public int EmploymentTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public Employee CreatedBy { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public Requisition Requisition { get; set; }
        public JobStatus JobStatus { get; set; }
        public ICollection<JobApplication> JobApplications { get; set; }
    }
}

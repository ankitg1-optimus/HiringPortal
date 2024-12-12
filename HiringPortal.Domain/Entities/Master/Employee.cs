using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Domain.Entities.Master
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeTypeId { get; set; } 

        //navigation properties
        public Role Role { get; set; }
        public Department Department { get; set; }
        public EmployeeType EmployeeType { get; set; } 
        public ICollection<Requisition> Reviews { get; set; }
        public ICollection<Requisition> Requisitions { get; set; }
        public ICollection<JobApplication> Referrals { get; set; }
        //public ICollection<JobApplication> JobApplicationsCreated { get; set; }
        public ICollection<Job> JobsCreated { get; set; }
    }
}

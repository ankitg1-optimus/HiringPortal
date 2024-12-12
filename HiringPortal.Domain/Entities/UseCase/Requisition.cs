using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Domain.Entities.UseCase
{
    public class Requisition
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
        public int RequisitionStatusId { get; set; }
        public int? EmployeeId { get; set; }
        public string Remarks { get; set; }
        public int? ReviewerId { get; set; }
        //navigation properties
        public Role Role { get; set; }
        public Department Department { get; set; }
        public Employee Employee { get; set; }
        public Employee Reviewer { get; set; }
        public RequisitionStatus RequisitionStatus { get; set; }
        public Job Job { get; set; }
    }
}

using HiringPortal.Domain.Entities.UseCase;
using HiringPortal.Domain.Entities.Master;

namespace HiringPortal.Domain.Entities.Static
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Requisition> Requisitions { get; set; }
    }
}

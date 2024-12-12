using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Domain.Entities.Static
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Requisition> Requistions { get; set; }
    }
}

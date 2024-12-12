using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Domain.Entities.Static
{
    public class EmployeeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}

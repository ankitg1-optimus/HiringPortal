using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Domain.Entities.Static
{
    public class RequisitionStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Requisition> Requisitions { get; set; }
    }
}

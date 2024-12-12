using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Domain.Entities.Static
{
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Interview> Interviews { get; set; }
    }
}

using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Domain.Entities.Static
{
    public class JobStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}

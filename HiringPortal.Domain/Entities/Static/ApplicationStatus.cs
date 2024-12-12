using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Domain.Entities.Static
{
    public class ApplicationStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<JobApplication> JobApplications { get; set; }
    }
}

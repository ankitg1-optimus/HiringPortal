using System.ComponentModel.DataAnnotations;
using HiringPortal.Domain.Entities.Static;
using HiringPortal.Domain.Entities.UseCase;

namespace HiringPortal.Domain.Entities.Master
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ResumeLink { get; set; }
        public string DocumentLink { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<JobApplication> JobApplications { get; set; }
    }
}

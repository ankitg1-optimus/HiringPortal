using System.ComponentModel.DataAnnotations.Schema;
using HiringPortal.Domain.Entities.Master;
using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Domain.Entities.UseCase
{
    public class JobApplication
    {
        public int Id { get; set; }
        //public int CreatedById { get; set; }
        public int JobId { get; set; }
        public int CandidateId { get; set; }
        public int ReferrerEmployeeId { get; set; }
        public int StatusId { get; set; }
        public string Remarks { get; set; }

        //navigation properties
        public Candidate Candidate { get; set; }
        //public Employee CreatedBy { get; set; }
        public Employee ReferrerEmployee { get; set; }
        public Job Job { get; set; }
        public ApplicationStatus Status { get; set; }
        public ICollection<Interview> Interviews {  get; set; }
    }
}

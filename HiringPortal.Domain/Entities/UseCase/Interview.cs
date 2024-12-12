using HiringPortal.Domain.Entities.Static;

namespace HiringPortal.Domain.Entities.UseCase
{
    public class Interview
    {
        public int Id { get; set; }
        public int JobApplicationId { get; set; }
        public int InterviewStatusId { get; set; }
        public DateTime Slot { get; set; }
        public int StageId { get; set; }
        public string Remarks { get; set; }
        public Stage Stage { get; set; }
        public InterviewStatus InterviewStatus { get; set; }
        public JobApplication JobApplication { get; set; }
    }
}

namespace CleanCode_JobTracker_API.DTOs
{
    public class JobApplicationRequestDto
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public DateTime AppliedDate { get; set; }
        public string Notes { get; set; }
    }
}

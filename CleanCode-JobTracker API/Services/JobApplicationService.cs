using CleanCode_JobTracker_API.DTOs;
using CleanCode_JobTracker_API.Models;

namespace CleanCode_JobTracker_API.Services
{
    public class JobApplicationService
    {
        public void SaveJobApplication(JobApplicationRequestDto dto)
        {
            // Clean conversion and potential DB save logic
            var job = new JobApplication
            {
                CompanyName = dto.CompanyName,
                Position = dto.Position,
                Status = dto.Status,
                AppliedDate = dto.AppliedDate,
                Notes = dto.Notes
            };

            Console.WriteLine($"[SERVICE] Saving {job.CompanyName} - {job.Position} to database...");
            // Simulated DB logic
        }
    }
}

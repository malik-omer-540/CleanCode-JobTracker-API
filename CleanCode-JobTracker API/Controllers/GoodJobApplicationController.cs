using CleanCode_JobTracker_API.DTOs;
using CleanCode_JobTracker_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanCode_JobTracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodJobApplicationController : ControllerBase
    {
        private readonly JobApplicationService _jobApplicationService;

        public GoodJobApplicationController(JobApplicationService service)
        {
            _jobApplicationService = service;
        }

        [HttpPost]
        public IActionResult CreateJobApplication([FromBody] JobApplicationRequestDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _jobApplicationService.SaveJobApplication(dto);
            return Ok("Job application saved successfully.");
        }
    }
}

using CleanCode_JobTracker_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanCode_JobTracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadJobApplicationController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateJob([FromBody] JobApplication job)
        {
            // No validation, hardcoded logic, no service layer, poor naming
            if (job.CompanyName != null && job.Position != null)
            {
                Console.WriteLine("Saving to DB: " + job.CompanyName + " for " + job.Position);
                return Ok("Saved");
            }

            return BadRequest("Missing data");
        }
    }
}

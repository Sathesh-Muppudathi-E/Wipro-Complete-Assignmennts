using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Services;

namespace TrainingManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentsController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEnrollments()
        {
            var enrollments = await _enrollmentService.GetAllEnrollmentsAsync();
            return Ok(enrollments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEnrollment(int id)
        {
            var enrollment = await _enrollmentService.GetEnrollmentByIdAsync(id);
            if (enrollment == null)
                return NotFound();

            return Ok(enrollment);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEnrollment([FromBody] Enrollment enrollment)
        {
            var createdEnrollment = await _enrollmentService.CreateEnrollmentAsync(enrollment);
            return CreatedAtAction(nameof(GetEnrollment), new { id = createdEnrollment.Id }, createdEnrollment);
        }

        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateEnrollmentStatus(int id, [FromBody] string status)
        {
            var updated = await _enrollmentService.UpdateEnrollmentStatusAsync(id, status);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrollment(int id)
        {
            var deleted = await _enrollmentService.DeleteEnrollmentAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}

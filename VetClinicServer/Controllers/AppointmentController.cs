using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using VetClinicServer.DTOs;
using VetClinicServer.Services;

namespace VetClinicServer.Controllers
{
    [ApiController]
    [Route("api/appointments")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all appointments")]
        public async Task<ActionResult<IEnumerable<AppointmentDTO>>> GetAppointments()
        {
            var appointments = await _appointmentService.GetAllAsync();

            return Ok(appointments);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get appointment by id")]
        public async Task<ActionResult<AppointmentDTO>> GetAppointment(int id)
        {
            var appointment = await _appointmentService.GetByIdAsync(id);

            return Ok(appointment);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create new appointment")]
        public async Task<ActionResult<AppointmentDTO>> PostAppointment([FromBody] AppointmentDTO appointmentDto)
        {
            appointmentDto = await _appointmentService.CreateAsync(appointmentDto);

            return CreatedAtAction(nameof(GetAppointment), new { id = appointmentDto.AppointmentId }, appointmentDto);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Update appointment")]
        public async Task<ActionResult<AppointmentDTO>> Put([FromBody] AppointmentDTO appointmentDto)
        {
            await _appointmentService.UpdateAsync(appointmentDto);

            return NoContent();
        }

        [HttpGet]
        [Route("/api/doctors/{id}/appointments")]
        [SwaggerOperation(Tags = new[] { "Doctor" }, 
            Summary = "Get appointments for doctor")]
        public async Task<ActionResult<IEnumerable<AppointmentDTO>>> GetForDoctor(int id)
        {
            var appointments = await _appointmentService.GetForDoctorAsync(id);

            return Ok(appointments);
        }

        [HttpGet]
        [Route("/api/patients/{id}/appointments")]
        [SwaggerOperation(Tags = new[] { "Patient" },
            Summary = "Get appointments for patient")]
        public async Task<ActionResult<IEnumerable<AppointmentDTO>>> GetForPatient(int id)
        {
            var appointments = await _appointmentService.GetForPatientAsync(id);

            return Ok(appointments);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete appointment")]
        public async Task<ActionResult> Delete(int id)
        {
            await _appointmentService.RemoveAsync(id);

            return NoContent();
        }
    }

}

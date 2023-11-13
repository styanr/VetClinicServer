using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<AppointmentDTO>>> GetAppointments()
        {
            var appointments = await _appointmentService.GetAllAsync();

            return Ok(appointments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppointmentDTO>> GetAppointment(int id)
        {
            var appointment = await _appointmentService.GetByIdAsync(id);

            return Ok(appointment);
        }

        [HttpPost]
        public async Task<ActionResult<AppointmentDTO>> PostAppointment([FromBody] AppointmentDTO appointmentDto)
        {
            appointmentDto = await _appointmentService.CreateAsync(appointmentDto);

            return CreatedAtAction(nameof(GetAppointment), new { id = appointmentDto.AppointmentId }, appointmentDto);
        }

        [HttpPut]
        public async Task<ActionResult<AppointmentDTO>> Put([FromBody] AppointmentDTO appointmentDto)
        {
            await _appointmentService.UpdateAsync(appointmentDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _appointmentService.RemoveAsync(id);

            return NoContent();
        }
    }

}

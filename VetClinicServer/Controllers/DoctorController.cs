using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using VetClinicServer.DTOs;
using VetClinicServer.Services;

namespace VetClinicServer.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get doctors")]
        public async Task<ActionResult<IEnumerable<DoctorDTO>>> GetDoctors()
        {
            var doctors = await _doctorService.GetAllAsync();
            
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get doctor by id")]
        public async Task<ActionResult<DoctorDTO>> GetDoctor(int id)
        {
            var doctor = await _doctorService.GetByIdAsync(id);
            
            return Ok(doctor);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create doctor")]
        public async Task<IActionResult> PostDoctor([FromBody] DoctorDTO doctorDto)
        {
            doctorDto = await _doctorService.CreateAsync(doctorDto);
            
            return CreatedAtAction(nameof(GetDoctor), new { id = doctorDto.DoctorId }, doctorDto);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Update doctor")]
        public async Task<IActionResult> PutDoctor([FromBody] DoctorDTO doctorDto)
        {
            await _doctorService.UpdateAsync(doctorDto);
            
            return NoContent();
        }

        [HttpDelete("{id}"),
            SwaggerOperation(Summary = "Delete doctor")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await _doctorService.RemoveAsync(id);
            
            return NoContent();
        }
    }

}

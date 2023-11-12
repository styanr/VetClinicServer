using Microsoft.AspNetCore.Mvc;
using VetClinicServer.DTOs;
using VetClinicServer.Services;

namespace VetClinicServer.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoctorDTO>>> GetDoctors()
        {
            var doctors = await _doctorService.GetAllAsync();
            
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DoctorDTO>> GetDoctor(int id)
        {
            var doctor = await _doctorService.GetByIdAsync(id);
            
            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> PostDoctor([FromBody] DoctorDTO doctorDto)
        {
            doctorDto = await _doctorService.CreateAsync(doctorDto);
            
            return CreatedAtAction(nameof(GetDoctor), new { id = doctorDto.DoctorId }, doctorDto);
        }

        [HttpPut]
        public async Task<IActionResult> PutDoctor([FromBody] DoctorDTO doctorDto)
        {
            await _doctorService.UpdateAsync(doctorDto);
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await _doctorService.RemoveAsync(id);
            
            return NoContent();
        }
    }

}

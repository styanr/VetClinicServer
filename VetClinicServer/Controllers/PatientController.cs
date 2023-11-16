using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using VetClinicServer.DTOs;
using VetClinicServer.Services;

namespace VetClinicServer.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get patients")]
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetPatients()
        {
            var patients = await _patientService.GetAllAsync();
            
            return Ok(patients);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get patient by id")]
        public async Task<ActionResult<PatientDTO>> GetPatient(int id)
        {
            var patient = await _patientService.GetByIdAsync(id);

            return Ok(patient);
        }

        [HttpGet]
        [Route("/api/clients/{id}/patients")]
        [SwaggerOperation(Tags = new[] {"Client"},
            Summary = "Get patients by client id")]
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetByClientId(int id)
        {
            var result = await _patientService.GetForClientAsync(id);

            return Ok(result);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create patient")]
        public async Task<IActionResult> PostPatient([FromBody] PatientDTO patientDto)
        {
            patientDto = await _patientService.CreateAsync(patientDto);
            
            return CreatedAtAction(nameof(GetPatient), new { id = patientDto.PatientId }, patientDto);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Update patient")]
        public async Task<IActionResult> PutPatient([FromBody] PatientDTO patientDto)
        {
            await _patientService.UpdateAsync(patientDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete patient")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            await _patientService.RemoveAsync(id);

            return NoContent();
        }
    }

}

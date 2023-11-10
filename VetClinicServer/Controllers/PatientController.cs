using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VetClinicServer.DTOs;
using VetClinicServer.Exceptions;
using VetClinicServer.Models;
using VetClinicServer.Services;

namespace VetClinicServer.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetPatients()
        {
            var patients = await _patientService.GetAllPatients();
            
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PatientDTO>> GetPatient(int id)
        {
            var patient = await _patientService.GetPatientById(id);

            return Ok(patient);
        }


        [HttpPost]
        public async Task<IActionResult> PostPatient([FromBody] PatientDTO patientDto)
        {
            patientDto = await _patientService.CreatePatient(patientDto);
            
            return CreatedAtAction(nameof(GetPatient), new { id = patientDto.PatientId }, patientDto);
        }

        [HttpPut]
        public async Task<IActionResult> PutPatient([FromBody] PatientDTO patientDto)
        {
            await _patientService.UpdatePatient(patientDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            if (await _patientService.RemovePatient(id))
            {
                return NoContent();
            }

            return NotFound("Patient not found");
        }
    }

}

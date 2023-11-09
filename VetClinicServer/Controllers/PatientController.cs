using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
        {
            var patients = await _patientService.GetAllPatients();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            var patient = await _patientService.GetPatientById(id);
            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }


        [HttpPost]
        public async Task<ActionResult<Patient>> PostPatient([FromBody] Patient patient)
        {
            var newPatient = await _patientService.CreatePatient(patient);
            
            return CreatedAtAction(nameof(GetPatient), new { id = newPatient.PatientId }, newPatient);
        }

        [HttpPut]
        public async Task<IActionResult> PutPatient([FromBody] Patient patient)
        {
            var updatedPatient = await _patientService.UpdatePatient(patient);
            if (updatedPatient == null)
            {
                return NotFound();
            }

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

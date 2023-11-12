﻿using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<PatientDTO>>> GetPatients()
        {
            var patients = await _patientService.GetAllAsync();
            
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PatientDTO>> GetPatient(int id)
        {
            var patient = await _patientService.GetByIdAsync(id);

            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> PostPatient([FromBody] PatientDTO patientDto)
        {
            patientDto = await _patientService.CreateAsync(patientDto);
            
            return CreatedAtAction(nameof(GetPatient), new { id = patientDto.PatientId }, patientDto);
        }

        [HttpPut]
        public async Task<IActionResult> PutPatient([FromBody] PatientDTO patientDto)
        {
            await _patientService.UpdateAsync(patientDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            await _patientService.RemoveAsync(id);

            return NoContent();
        }
    }

}

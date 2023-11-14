using Microsoft.AspNetCore.Mvc;
using VetClinicServer.DTOs;
using VetClinicServer.Services;

namespace VetClinicServer.Controllers
{
    [ApiController]
    [Route("api/medications")]
    public class MedicationController : ControllerBase
    {
        private readonly IMedicationService _medicationService;

        public MedicationController(IMedicationService medicationService)
        {
            _medicationService = medicationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicationDTO>>> GetMedications()
        {
            var medications = await _medicationService.GetAllAsync();

            return Ok(medications);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MedicationDTO>> GetMedication(int id)
        {
            var medication = await _medicationService.GetByIdAsync(id);

            return Ok(medication);
        }

        [HttpPost]
        public async Task<ActionResult<MedicationDTO>> PostMedication([FromBody] MedicationDTO medicationDto)
        {
            medicationDto = await _medicationService.CreateAsync(medicationDto);

            return CreatedAtAction(nameof(GetMedication), new { id = medicationDto.MedicationId }, medicationDto);
        }

        [HttpPut]
        public async Task<ActionResult<MedicationDTO>> Put([FromBody] MedicationDTO medicationDto)
        {
            await _medicationService.UpdateAsync(medicationDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _medicationService.RemoveAsync(id);

            return NoContent();
        }
    }

}

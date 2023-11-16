using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
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
        [SwaggerOperation(Summary = "Get medications")]
        public async Task<ActionResult<IEnumerable<MedicationDTO>>> GetMedications()
        {
            var medications = await _medicationService.GetAllAsync();

            return Ok(medications);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get medication by id")]
        public async Task<ActionResult<MedicationDTO>> GetMedication(int id)
        {
            var medication = await _medicationService.GetByIdAsync(id);

            return Ok(medication);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create medication")]
        public async Task<ActionResult<MedicationDTO>> PostMedication([FromBody] MedicationDTO medicationDto)
        {
            medicationDto = await _medicationService.CreateAsync(medicationDto);

            return CreatedAtAction(nameof(GetMedication), new { id = medicationDto.MedicationId }, medicationDto);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Update medication")]
        public async Task<ActionResult<MedicationDTO>> Put([FromBody] MedicationDTO medicationDto)
        {
            await _medicationService.UpdateAsync(medicationDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete medication")]
        public async Task<ActionResult> Delete(int id)
        {
            await _medicationService.RemoveAsync(id);

            return NoContent();
        }
    }

}

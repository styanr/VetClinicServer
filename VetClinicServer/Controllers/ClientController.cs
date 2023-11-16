using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using VetClinicServer.DTOs;
using VetClinicServer.Services;

namespace VetClinicServer.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get clients")]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetClients()
        {
            var clients = await _clientService.GetAllAsync();

            return Ok(clients);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get client by id")]
        public async Task<ActionResult<ClientDTO>> GetClient(int id)
        {
            var client = await _clientService.GetByIdAsync(id);
            
            return Ok(client);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create client")]
        public async Task<ActionResult<ClientDTO>> PostClient([FromBody] ClientDTO clientDto)
        {
            clientDto = await _clientService.CreateAsync(clientDto);
            
            return CreatedAtAction(nameof(GetClient), new { id = clientDto.ClientId }, clientDto);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Update client")]
        public async Task<ActionResult<ClientDTO>> Put([FromBody] ClientDTO clientDto)
        {
            await _clientService.UpdateAsync(clientDto);
            
            return NoContent();
        }

        [HttpGet]
        [Route("/api/patients/{id}/client")]
        [SwaggerOperation(Tags = new[] { "Patient" },
            Summary = "Get client by patient id")]
        public async Task<ActionResult<ClientDTO>> GetByPatientId(int id)
        {
            var result = await _clientService.GetByPatientId(id);
            
            return Ok(result);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete client")]
        public async Task<ActionResult> Delete(int id)
        {
            await _clientService.RemoveAsync(id);
            
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetClients()
        {
            var clients = await _clientService.GetAllAsync();

            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDTO>> GetClient(int id)
        {
            var client = await _clientService.GetByIdAsync(id);
            
            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<ClientDTO>> PostClient([FromBody] ClientDTO clientDto)
        {
            clientDto = await _clientService.CreateAsync(clientDto);
            
            return CreatedAtAction(nameof(GetClient), new { id = clientDto.ClientId }, clientDto);
        }

        [HttpPut]
        public async Task<ActionResult<ClientDTO>> Put([FromBody] ClientDTO clientDto)
        {
            await _clientService.UpdateAsync(clientDto);
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _clientService.RemoveAsync(id);
            
            return NoContent();
        }
    }
}

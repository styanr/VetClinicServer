using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Exceptions;
using VetClinicServer.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VetClinicServer.Controllers
{
    [Route("api/clients")]
    [ApiController]
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
            var clients = await _clientService.GetAllClients();


            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDTO>> GetClient(int id)
        {
            try
            {
                var client = await _clientService.GetClientById(id);
                return Ok(client);
            }
            catch (ResourceNotFoundException exception)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ClientDTO>> PostClient([FromBody] ClientDTO client)
        {
            await _clientService.CreateClient(client);
            
            return CreatedAtAction(nameof(GetClient), new { id = client.ClientId }, client);
        }

        [HttpPut]
        public async Task<ActionResult<ClientDTO>> Put([FromBody] ClientDTO client)
        {
            try
            {
                await _clientService.UpdateClient(client);
            }
            catch (ResourceNotFoundException exception)
            {
                return NotFound(new { message = exception.Message });
            }
            catch (DbUpdateException exception)
            {
                return BadRequest(new { message = exception.Message});
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (await _clientService.RemoveClient(id))
                    return NoContent();
                return BadRequest();
            }
            catch (ResourceNotFoundException exception)
            {
                return NotFound(new { message = exception.Message });
            }
        }
    }
}

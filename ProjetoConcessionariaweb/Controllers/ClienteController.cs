using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
using ProjetoConcessionariaweb.DTOs;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public static List<ClienteDTO> Clientes {get; set;} = new List<ClienteDTO>();
    
        [HttpPost("SetCliente")]
        public IActionResult SetCliente(ClienteDTO clienteDto)
        {
            try
            {
                var cliente = new Cliente(clienteDto.Nome, clienteDto.Cpf, clienteDto.DataNascimento,
                clienteDto.Email, clienteDto.Telefone);
                Clientes.Add(clienteDto);
                return Ok(Clientes);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
   
        [HttpGet("GetCliente")]
        public IActionResult GetClientes()
        {
            return Ok(Clientes);
        }
        [HttpDelete]
        public IActionResult DeleteCliente(ClienteDTO clienteDto)
        {    
           var index = Clientes.Count<ClienteDTO>(); 
           Clientes.RemoveAt(index -1);
           return Ok(Clientes);
        }
    }
}
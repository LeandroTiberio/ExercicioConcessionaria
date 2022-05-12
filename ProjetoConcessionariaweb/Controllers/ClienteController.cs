using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public List<Cliente> Clientes {get; set;} = new List<Cliente>();
    }
    [HttpPost]
    public IActionResult SetCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
        return Ok (Clientes);
    }
    [HttpGet()]
    public IActionResult GetClientes()
    {
        return Ok (Clientes);
    }
}
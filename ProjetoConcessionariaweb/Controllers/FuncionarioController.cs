using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<Funcionario> Funcionarios {get; set;} = new List<Funcionario>();

        [HttpPost]
        public IActionResult SetFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
            return Ok(Funcionarios);
        }
        [HttpGet()]
        public IActionResult GetFuncionarios()
        {
            return Ok(Funcionarios);
        }
        [HttpDelete]
        public IActionResult DeleteCliente(Funcionario funcionario)
        {    
           Funcionarios.Remove(funcionario);
           return Ok(Funcionarios);
        }
    }
}
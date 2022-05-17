using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
using ProjetoConcessionariaweb.DTOs;

namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<FuncionarioDTO> Funcionarios {get; set;} = new List<FuncionarioDTO>();

        [HttpPost("SetFuncionario")]
        public IActionResult SetFuncionario(FuncionarioDTO funcionarioDto)
        {
            try
            {
                var funcionario = new Funcionario(funcionarioDto.Nome, funcionarioDto.Cpf, 
                funcionarioDto.DataNascimento, funcionarioDto.Cargo );
                Funcionarios.Add(funcionarioDto);
                return Ok(Funcionarios);
            }
            catch (System.Exception ex)
            {
                return BadRequest (ex.Message);
            }
        }
        [HttpGet("GetFuncionario")]
        public IActionResult GetFuncionarios()
        {
            return Ok(Funcionarios);
        }
        [HttpDelete]
        public IActionResult DeleteCliente()
        { 
           var index = Funcionarios.Count<FuncionarioDTO>();    
           Funcionarios.RemoveAt(index -1);
           return Ok(Funcionarios);
        }
    }
}

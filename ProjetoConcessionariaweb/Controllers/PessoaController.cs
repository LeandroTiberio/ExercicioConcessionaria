using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
using ProjetoConcessionariaweb.DTOs;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConcessionariaController : ControllerBase
    {
        public static List<PessoaDTO> Pessoas {get; set;} = new List<PessoaDTO>();
        [HttpPost("SetPessoa")]
        public IActionResult SetPessoaPadrao(PessoaDTO pessoaDto)
        {
            try
            {
                var pessoa = new Pessoa(pessoaDto.Nome, pessoaDto.Cpf, pessoaDto.DataNascimento);
                Pessoas.Add(pessoaDto);
                return Ok(Pessoas);
            }
            catch (System.Exception ex)
            {
                return BadRequest (ex.Message);
            }
            
        }

        [HttpGet("GetPessoa")]
        public IActionResult GetPessoas()
        {
            return Ok(Pessoas);
        }
        [HttpDelete]
        public IActionResult DeletePessoas()
        {
            var index = Pessoas.Count<PessoaDTO>();
            Pessoas.RemoveAt(index -1);
            return Ok(Pessoas);
        }            
    }
}
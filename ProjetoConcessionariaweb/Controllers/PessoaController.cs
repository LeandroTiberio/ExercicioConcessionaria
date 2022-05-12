using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConcessionariaController : ControllerBase
    {
        public List<Pessoa> PessoaDaClasse {get; set;} = new List<Pessoa>();
        [HttpPost]
        public IActionResult SetPessoaPadrao(Pessoa pessoa)
        {
            PessoaDaClasse.Add(pessoa);
            return Ok(PessoaDaClasse);
        }

        [HttpGet()]
        public IActionResult GetPessoaDaClasse()
        {
            return Ok(PessoaDaClasse);
        }
            
    }
}
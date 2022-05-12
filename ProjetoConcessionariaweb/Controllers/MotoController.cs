using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public List<Moto> Motos {get; set;} = new List<Moto>();

        [HttpPost]
        public IActionResult SetMoto(Moto moto)
        {
            Motos.Add(moto);
            return Ok(Motos);
        }
        [HttpGet()]
        public IActionResult GetMotos()
        {
            return Ok(Motos);
        }
        [HttpDelete]
        public IActionResult DeleteMoto(Moto moto)
        {
            Motos.Remove(moto);
            return Ok(Motos);
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<Carro> Carros {get; set;} = new List<Carro>();
        
        [HttpPost]
        public IActionResult SetCarro(Carro carro)
        {
            Carros.Add(carro);
            return Ok (Carros);
        }
        [HttpGet()]
        public IActionResult GetCarros()
        {
            return Ok (Carros);
        }
       [HttpDelete]
       public IActionResult DeleteCarro(Carro carro)
       {
           var CountCarros = Carros.Count<Carro>();
           Carros.RemoveAt(CountCarros -1);
           return Ok(carro);
       }

    }
}


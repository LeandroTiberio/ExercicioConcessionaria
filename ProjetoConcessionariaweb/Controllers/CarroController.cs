using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
using ProjetoConcessionariaweb.DTOs;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<CarroDTO> Carros {get; set;} = new List<CarroDTO>();
        
        [HttpPost("SetCarro")]
        public IActionResult SetCarro(CarroDTO carroDto)
        {
            try 
            {
                var carro = new Carro(carroDto.Marca, carroDto.Modelo, carroDto.Ano, carroDto.Kilometragem,
                carroDto.Cor, carroDto.Valor, carroDto.TransmissaoAutomatica, carroDto.Combustivel);
                Carros.Add(carroDto);
                return Ok (Carros);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
            
        }
        [HttpGet("GetCarro")]
        public IActionResult GetCarros()
        {
            return Ok (Carros);
        }
       [HttpDelete]
       public IActionResult DeleteCarro(Carro carro)
       {
           var index = Carros.Count<CarroDTO>();
           Carros.RemoveAt(index -1);
           return Ok(carro);
       }

    }
}


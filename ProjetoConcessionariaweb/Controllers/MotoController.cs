using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
using ProjetoConcessionariaweb.DTOs;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase 
    {
        public static List<MotoDTO> Motos {get; set;} = new List<MotoDTO>();

        [HttpPost("SetMoto")]
        public IActionResult SetMoto(MotoDTO motoDto)
        {
            try
            {   var moto = new Moto(motoDto.Marca, motoDto.Modelo, motoDto.Ano, motoDto.Kilometragem, 
            motoDto.Cor, motoDto.Valor, motoDto.Cilindrada, motoDto.Partida );
                Motos.Add(motoDto);
                return Ok(Motos);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("GetMoto")]
        public IActionResult GetMotos()
        {
            return Ok(Motos);
        }
        [HttpDelete]
        public IActionResult DeleteMoto(MotoDTO motoDto)
        {
            var index = Motos.Count<MotoDTO>();
            Motos.RemoveAt(index -1);
            return Ok(Motos);
        }

    }
}
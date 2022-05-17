using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
using ProjetoConcessionariaweb.DTOs;

namespace ProjetoConcessionariaweb.Controllers;

[ApiController]
[Route("[controller]")]

public class VeiculoController : ControllerBase
{
    public static List<VeiculoDTO> Veiculos { get; set; } = new List<VeiculoDTO>();

    [HttpPost("SetVeiculo")]
    public IActionResult SetVeiculo(VeiculoDTO veiculoDto)
    {
        try
        {
            var veiculo = new Veiculo(veiculoDto.Marca, veiculoDto.Modelo, veiculoDto.Ano, veiculoDto.Kilometragem, veiculoDto.Cor, veiculoDto.Valor);
            Veiculos.Add(veiculoDto);
            return Ok(Veiculos);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
        
    }

    [HttpGet("GetVeiculo")]
    public IActionResult GetVeiculo()
    {
        return Ok(Veiculos);
    }

    [HttpDelete]
    public IActionResult DeleteVeiculo()
    {
        var CountVeiculos = Veiculos.Count<VeiculoDTO>();
        Veiculos.RemoveAt(CountVeiculos -1);
        return Ok(Veiculos);
    }
    
}



    
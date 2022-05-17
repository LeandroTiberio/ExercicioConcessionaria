using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
using ProjetoConcessionariaweb.DTOs;

namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public static List<VendaDTO> Vendas {get; set;} = new List<VendaDTO>();

        [HttpPost("SetVenda")]
        public IActionResult SetVenda(VendaDTO vendaDto)
        {
            try
            {
                var venda = new Venda(vendaDto.Comprador, vendaDto.Vendedor, vendaDto.Veiculo,
                vendaDto.FormaPagamento, vendaDto.ValorFinal);
                Vendas.Add(vendaDto);
                return Ok(Vendas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
            
        [HttpGet("GetVenda")]
        public IActionResult GetVenda()
        {
            return Ok(Vendas);
        }
        [HttpDelete]
        public IActionResult DeleteVenda()
        {
            var CountVendas = Vendas.Count<VendaDTO>();
            Vendas.RemoveAt(CountVendas -1);
            return Ok(Vendas);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ExercicioConcessionaria.Models;
namespace ProjetoConcessionariaweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public static List<Venda> Vendas {get; set;} = new List<Venda>();

        [HttpPost]
        public IActionResult SetVenda(Venda venda)
        {
            Vendas.Add(venda);
            return Ok(Vendas);
        }
        [HttpGet]
        public IActionResult GetVendas()
        {
            return Ok(Vendas);
        }
        [HttpDelete]
        public IActionResult DeleteVenda(Venda venda)
        {
            Vendas.Remove(venda);
            return Ok(Vendas);
        }
    }
}
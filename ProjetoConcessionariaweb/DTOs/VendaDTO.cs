using ExercicioConcessionaria.Models;
namespace ProjetoConcessionariaweb.DTOs
{
    public class VendaDTO
    {
        public Cliente Comprador { get; set; }
        public Funcionario Vendedor { get; set; }
        public Veiculo Veiculo { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorFinal { get; set; }
    }
}
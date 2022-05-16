namespace ExercicioConcessionaria.Models
{
    public class Venda
    {
        public Cliente Comprador { get; set; }
        public Funcionario Vendedor { get; set; }
        public Veiculo Veiculo { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorFinal { get; set; }

        public Venda (Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formaPagamento, double valorFinal)
        {
            SetComprador (comprador);
            SetVendedor (vendedor);
            SetVeiculo (veiculo);
            SetFormaPagamento (formaPagamento);
            SetValorFinal (valorFinal);
        }

        //Get e Set Comprador
        public Cliente GetComprador()
        {
            return Comprador;
        }
        public void SetComprador(Cliente comprador)
        {
            Comprador = comprador;
        }

        //Get e Set Vendedor
        public Funcionario GetVendedor()
        {
            return Vendedor;
        }
        public void SetVendedor(Funcionario vendedor)
        {
            Vendedor = vendedor;
        }

        //Get e Set Veiculo
        public Veiculo GetVeiculo()
        {
            return Veiculo;
        }
        public void SetVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }

        //Get e Set FormaPagamento
        public string GetFormaPagamento()
        {
            return FormaPagamento;
        }
        public void SetFormaPagamento(string formapagamento)
        {
            FormaPagamento = formapagamento;
        }
        //Get e Set ValorFinal
        public double GetValorFinal()
        {
            return ValorFinal;
        }
        public void SetValorFinal(double valorfinal)
        {
            ValorFinal = valorfinal;
        }
       public void AplicarDesconto(double desconto)
        {
            if (Vendedor.GetCargo()== "Gerente")
            {
                desconto = ValorFinal *0.95;
            }
        }
    
    }
}

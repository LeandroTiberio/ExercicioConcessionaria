using ExercicioConcessionaria.Exceptions;
namespace ExercicioConcessionaria.Models

{
    public class Carro : Veiculo
    {
        private bool TransmissaoAutomatica { get; set; }
        private string Combustivel { get; set; }

        public override double CalcularValor(double valor)
        {
            return valor;
        }

        public Carro (string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor, bool transmissaoautomatica, string combustivel) 
                        : base ( marca, modelo, ano, kilometragem, cor, valor)
        {
            SetTransmissaoAutomatica (transmissaoautomatica);
            SetCombustivel (combustivel);
        }
        //Get e Set TransmisãoAutomática
        public bool GetTransmissaoAutomatica()
        {
            return TransmissaoAutomatica;
        }
        public void SetTransmissaoAutomatica(bool transmissaoautomatica)
        {
            TransmissaoAutomatica = transmissaoautomatica;
        }

        //Get e Set Combustível
        public string GetCombustivel()
        {
            return Combustivel;
        }
        public void SetCombustivel(string combustivel)
        {
            Combustivel = combustivel;
        }
         
        public bool ValidarValorCarro(double valorfinal)
        {
            if (valorfinal > 5000)
            {
                return true;
            }
            return false;
        }
        public void SetValidarValor(double validarvalor)
        {
            var ValidarValor = validarvalor;
            if(validarvalor > 5000)
            {
                throw new InputInvalidoException("Valor do carro não pode ser nemor que 5000");
            }
            ValidarValor = validarvalor;
        }

    }

}
 
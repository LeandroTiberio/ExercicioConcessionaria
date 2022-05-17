using System;
using ExercicioConcessionaria.Exceptions;
namespace ExercicioConcessionaria.Models
{
    public class Moto : Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }

        public override double CalcularValor(double valor)
        {
            if(Partida == "Eletrica")
            {
                valor = (Cilindrada*.50)*.10;
                return valor;
            }
            else
            {
                valor = (Cilindrada * 50);
                return valor;
            }
        }
        public Moto (string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor, int cilindrada, string partida)
                    : base ( marca, modelo, ano, kilometragem, cor, valor)
        {
            SetCilindrada (cilindrada);
            SetPartida (partida);
        }

        //Get e Set Cilindrada
        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }

        //Get e Set Partida
        public string GetPartida()
        {
            return Partida;
        }
        public void SetPartida(string partida)
        {
            
            if (Partida == "Eletrica")
            {
                throw new Exception("Partida não pode ser manual");
            }
            Partida = partida;
        }
        public bool ValidarValorMoto(double valorfinal)
        {
            if (valorfinal > 2000)
            {
                return true;
            }
            return false;
        }
        public void SetValidarValor(int validarvalor)
        {
            var ValidarValor = validarvalor;
            if(validarvalor  > 2000)
            {
                throw new InputInvalidoException("Valor do Moto não pode ser nemor que 2000");
            }
            ValidarValor = validarvalor;
        }
    }
}

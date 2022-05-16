using System;
namespace ExercicioConcessionaria.Models
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public string Partida { get; set; }

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
            Partida = partida;
            if (Partida == "Eletrica")
            {
                return;
            }
        }
         public bool ValidarValorMoto(double valorfinal)
        {
            if (valorfinal > 2000)
            {
                return true;
            }
            return false;
        }
    }
}

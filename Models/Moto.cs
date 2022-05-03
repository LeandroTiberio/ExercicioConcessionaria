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
            SetPartida (Partida);
        }

        //Get e Set Cilindrada
        public int GetCilindrada(int cilindrada)
        {
            return cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }

        //Get e Set Partida
        public string GetPartida(string partida)
        {
            return partida;
        }
        public void SetPartida(string partida)
        {
            Partida = partida;
        }
    }
}

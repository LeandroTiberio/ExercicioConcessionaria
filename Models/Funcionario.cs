namespace ExercicioConcessionaria.Models
{
    public class Funcionario : Pessoa
    {
         private string Cargo { get; set; }

        public Funcionario (string nome, string cpf, DateTime DataNascimento, string cargo) 
                            : base (nome, cpf, DataNascimento)
        {
            SetCargo (cargo);
        }
        public string GetCargo()
        {
            return Cargo;
        }
        
        public void SetCargo (string cargo)
        {
            Cargo = cargo;
        }
    }
}
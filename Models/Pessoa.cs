namespace ExercicioConcessionaria.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataNascimento { get; set; }

        public Pessoa ( string nome, string cpf, DateTime DataNascimento)
        {
            SetNome (nome);
            SetCpf (cpf);
            SetDataNascimento (DataNascimento);
        }

        

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome (string nome)
        {
            Nome = nome;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetCpf (string cpf)
        {
            Cpf = cpf;
        }
        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
        public void SetDataNascimento (DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }
    }

    
}
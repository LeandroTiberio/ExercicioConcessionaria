using System;
namespace ExercicioConcessionaria.Models
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public int Kilometragem { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }
        public virtual double CalcularValor(double valor)
        {
            return valor;
        }
        public Veiculo (string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor) 
        {
            SetMarca (marca);
            SetModelo (modelo);
            SetAno (ano);
            SetKilometragem (kilometragem);
            SetCor (cor);
            SetValor (valor);
        }                

        //Get e Set Marca
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        //Get e Set Modelo
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        //Get e Set Ano
        public DateTime GetAno()
        {
            return Ano;
        }
        public void SetAno(DateTime ano)
        {
            Ano = ano;
        }

        //Get e Set Kilometragem
        public int GetKilometragem()
        {
            return Kilometragem;
        }
        public void SetKilometragem(int kilometragem)
        {
            Kilometragem = kilometragem;
        }

        //Get e Set Cor
        public string GetCor()
        {
            return Cor;
        }
        public void SetCor(string cor)
        {
            Cor = cor;
        }

        //Get e Set Valor
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }

    }
    
}
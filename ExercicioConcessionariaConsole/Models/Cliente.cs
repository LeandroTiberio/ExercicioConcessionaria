using System;
using ExercicioConcessionaria.Exceptions;
namespace ExercicioConcessionaria.Models
{
    public class Cliente : Pessoa
    {
        private string Email { get; set; }
        private string Telefone { get; set; }

        public Cliente ( string nome, string cpf, DateTime dataNascimento, string email, string telefone) 
                        : base ( nome, cpf, dataNascimento)
        {
            SetEmail (email);
            SetTelefone (telefone);
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail (string email)
        {
            Email = email;
        }

        public void ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                throw new InputInvalidoException("Email ivalido");
            }
            Email = email;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone (string telefone)
        {
           Telefone = telefone;
        }
        public void ValidarTelefone(string telefone)
        {
            if(telefone.Length > 8 && telefone.Length < 15)
            {
                throw new InputInvalidoException("Telefome Invalido");
            }
            Telefone = telefone;
        }
        
        
    }

}
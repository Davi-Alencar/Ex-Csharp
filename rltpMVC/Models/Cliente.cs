using System;

namespace rltpMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public DateTime DataNascimento {get;set;}
        public string Cpfcnpj {get;set;}
        public string Telefone {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}

        public Cliente()
        {
            
        }

        public Cliente(string nome, DateTime dataNascimento, string cpfcnpj, string telefone, string email, string senha)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Cpfcnpj = cpfcnpj;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
        }
        
    }
}
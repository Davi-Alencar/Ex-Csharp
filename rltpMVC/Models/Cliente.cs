using System;

namespace rltpMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Telefone {get;set;}
        public string Endereco {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataNascimento {get;set;}

        public Cliente()
        {
            
        }

        public Cliente(string nome, string endereco, string telefone, string email, string senha, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }
        
    }
}
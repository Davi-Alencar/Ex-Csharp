using System.IO;
using Microsoft.AspNetCore.Mvc;
using rltpMVC.Models;

namespace rltpMVC.Repositorio
{
    public class ClienteRepositorio
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepositorio()
       {
           if(!File.Exists(PATH))
           {
               File.Create(PATH).Close();
           }
       }

       public bool Inserir(Cliente cliente)
       {
           var linha = new string[] {PrepararRegistroCSV(cliente)};
           File.AppendAllLines(PATH, linha);

           return true;
       }

       private string PrepararRegistroCSV(Cliente cliente)
       {
           return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
       }
    }
}
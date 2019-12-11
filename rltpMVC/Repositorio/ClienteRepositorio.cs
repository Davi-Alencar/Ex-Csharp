using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using rltpMVC.Models;

namespace rltpMVC.Repositorio
{
    public class ClienteRepositorio : RepositorioBase
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

       public Cliente ObterPor (string email)
       {
           var linhas = File.ReadAllLines(PATH);
           foreach (var item in linhas)
           {
               if(ExtrairValorDoCampo("email", item).Equals(email))
               {
                   Cliente c = new Cliente();
                   c.Nome = ExtrairValorDoCampo("nome", item);
                   c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                   c.Cpfcnpj = ExtrairValorDoCampo("cpfcnpj", item);
                   c.Email = ExtrairValorDoCampo("email", item);
                   c.Telefone = ExtrairValorDoCampo("telefone", item);
                   c.Senha = ExtrairValorDoCampo("senha", item);

                   return c;
               }
           }
           return null;
       }

       public string PrepararRegistroCSV(Cliente cliente)
       {
           return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};cpfcnpj={cliente.Cpfcnpj};email={cliente.Email};senha={cliente.Senha};telefone={cliente.Telefone};";
       }
    }
}
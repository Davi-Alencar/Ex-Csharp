using System;
using System.IO;
using McBonaldsMVC.Models;
namespace McBonaldsMVC.Repositories
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

       public Cliente ObterPor (string email)
       {
           var linhas = File.ReadAllLines(PATH);
           foreach (var item in linhas)
           {
               if(ExtrairValorDoCAmpo("email", item).Equals(email))
               {
                   Cliente c = new Cliente();
                   c.Nome = ExtrairValorDoCAmpo("nome", item);
                   c.Email = ExtrairValorDoCAmpo("email", item);
                   c.DataNascimento = DateTime.Parse(ExtrairValorDoCAmpo("data_nascimento", item));
                   c.Endereco = ExtrairValorDoCAmpo("endereco", item);
                   c.Telefone = ExtrairValorDoCAmpo("telefone", item);
                   c.Senha = ExtrairValorDoCAmpo("senha", item);

                   return c;
               }
           }
           return null;
       }

       private string ExtrairValorDoCAmpo(string nomeCampo, string linha)
       {
           var chave = nomeCampo;
           var indiceChave = linha.IndexOf(chave);
           var indiceTerminal = linha.IndexOf(";", indiceChave);
           var valor = "";

           if(indiceTerminal != -1)
           {
               valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
           } else {
               valor = linha.Substring(indiceChave);
           }
           System.Console.WriteLine($"Campo: {nomeCampo} e valor {valor}");
           return valor.Replace(nomeCampo + "=","");
       }

       private string PrepararRegistroCSV(Cliente cliente)
       {
           return $"nome = {cliente.Nome};email = {cliente.Email};senha = {cliente.Senha};endereco = {cliente.Endereco}; telefone = {cliente.Telefone}; data_nascismento = {cliente.DataNascimento}";
       }
   }
}
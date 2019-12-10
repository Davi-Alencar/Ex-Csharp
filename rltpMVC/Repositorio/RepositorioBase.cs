using System;

namespace rltpMVC.Repositorio
{
    public class RepositorioBase
    {
        public string ExtrairValorDoCampo(string nomeCampo, string linha)
       {
           var dateAndTime = DateTime.Now;
           var date = dateAndTime.Date;

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
           return valor.Replace(nomeCampo + "=", "");
       }
    }
}
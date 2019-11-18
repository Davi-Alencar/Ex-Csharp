using System;

namespace McBonaldsMVC.Models
{
   public class Hamburguer : Produto
   {
       public Hamburguer(string nome, double preco)
       {
           this.Nome = nome;
           this.Preco = preco;
       }
       public Hamburguer()
       {

       }

        internal static void Add(Hamburguer h)
        {
            throw new NotImplementedException();
        }
        //public Hamburguer(string nome, double preco)
    }
}
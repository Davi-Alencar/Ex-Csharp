using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositorio
{
    public class HamburguerRepositorio
    {
        private const string PATH = "Database/Hamburguer.csv";

        public double ObterPrecoDe(string nomeHamburguer)
        {
            var lista = ObterTodos();
            var preco = 0.0;

            foreach(var item in lista)
            {
                if(item.Nome.Equals(nomeHamburguer))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Hamburguer> ObterTodos()
        {
            List<Hamburguer> hamburguer = new List<Hamburguer>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Hamburguer h = new Hamburguer();
                string[] dados = linha.Split(";");
                h.Nome = dados[0];
                h.Preco = double.Parse(dados[1]);
                hamburguer.Add(h);
            }

            return hamburguer;
        }
    }
}
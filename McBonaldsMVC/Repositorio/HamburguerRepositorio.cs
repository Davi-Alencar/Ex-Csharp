using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositorio
{
    public class HamburguerRepositorio
    {
        private const string PATH = "Database/Hamburguer.csv";

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
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Baixo : instrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do Baixo!");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Baixo!");
            return true;
        }

        void IPercussao.ManterRitmo()
        {
            throw new System.NotImplementedException();
        }
    }
}
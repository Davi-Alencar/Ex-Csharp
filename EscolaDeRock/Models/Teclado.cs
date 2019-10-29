using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Teclado : instrumentoMusical, IMelodia, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do Teclado!");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Teclado!");
            return true;
        }

        public bool TocarSolo()
        {
            throw new System.NotImplementedException();
        }
    }
}
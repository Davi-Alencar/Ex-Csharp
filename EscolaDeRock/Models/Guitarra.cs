using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Guitarra : instrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Mantendo ritmo da Guitarra!");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo da Guitarra!");
            return true;
        }
    }
}
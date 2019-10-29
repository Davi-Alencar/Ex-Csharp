using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Violao : instrumentoMusical, IMelodia, IHarmonia, IPercussao
    {
        public void ManterRitmo()
        {
            throw new System.NotImplementedException();
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando os acordes do Violão!");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando o solo do Violão!");
            return true;
        }
    }
}
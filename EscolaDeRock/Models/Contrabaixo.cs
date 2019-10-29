using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Contrabaixo :  instrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do Contrabaixo!");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Contrabaixo!");
            return true;
        }

        void IPercussao.ManterRitmo()
        {
            throw new System.NotImplementedException();
        }
    }
}
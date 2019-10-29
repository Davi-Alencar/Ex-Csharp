using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Bateria : instrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo da Bateria!");
            return true;
        }

        public bool TocarAcordes()
        {
            throw new System.NotImplementedException();
        }

        void IPercussao.ManterRitmo()
        {
            throw new System.NotImplementedException();
        }
    }
}
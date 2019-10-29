using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Tambores : instrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo dos Tambores!");
            return true;
        }

        void IPercussao.ManterRitmo()
        {
            throw new System.NotImplementedException();
        }
    }
}
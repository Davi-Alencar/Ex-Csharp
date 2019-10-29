using System;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;

            do {
                System.Console.WriteLine("");
                int codigo = MenuUtils<LixosEnum>.ExibirMenuPadrao();
                Reciclar (Lixeira.lixos[codigo]);

            } while (!querSair);
        }
    }
}

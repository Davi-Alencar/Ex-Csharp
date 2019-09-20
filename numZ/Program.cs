using System;

namespace numZ
{
    class Program
    {
        static void Main(string[] args)
        {

            /*double Pares = 0; */
            /*double Impares = 0; */
            double Valor = 0;
            do {
                Console.WriteLine("Digite um número iNtEiRo, ou zero p/ encerrar: ");
                Valor = double.Parse(Console.ReadLine());

                
                if (Valor % 2 == 0) {
                    Console.WriteLine("Par");
                } else {
                    Console.WriteLine("Par?");
                }

            } while (Valor != 0);

            /* usando somente "while"

            double Pares = 0;
            double Impares = 0;
            double Valor = 1;

            while(Valor !=0) {
                Console.WriteLine("Digite um número INTeiro, ou zero p/ encerrar: ");
                Valor = double.Parse(Console.ReadLine());

                
                if (Valor % 2 == 0) {
                    Console.WriteLine("Par");
                } else {
                    Console.WriteLine("Par?");
                }

            } while (Valor != 0);

            
            
            
            
            */








        }
    }
}

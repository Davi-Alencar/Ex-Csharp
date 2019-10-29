using System;

namespace num_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[6];
            int par = 0;
            int impar = 0;
            
            for(int cont = 0; cont < 6; cont++) {
                Console.Write($"Digite o {cont+1} número: ");
                vector[cont] = int.Parse(Console.ReadLine());
            }

            foreach(int num in vector) {
                if(num % 2 == 0) {
                    par++;
                } else {
                    impar++;
                }
            }

            Console.WriteLine($"Você tem {par} número(os) pares e {impar} número(os) ímpares...");
        }
    }
}

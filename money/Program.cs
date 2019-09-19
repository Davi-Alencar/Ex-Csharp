using System;

namespace money
{
    class Program
    {
        static void Main(string[] args)
        {

            double Salario = 0;
            double Minimo = 500;
            double Aumento = 0;

            Console.WriteLine("Digite o valor de seu salário:");
            Salario = int.Parse(Console.ReadLine());    

            Aumento = Salario / 30;

            if (Salario < Minimo) { 
                Console.WriteLine($"{Salario} + {Aumento}  = {Salario + Aumento}");
            }



            else {
                Console.WriteLine("Sem direito ao benefício!");
            }
        }
    }
}

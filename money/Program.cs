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
            Salario = double.Parse(Console.ReadLine());    

            Aumento = Salario * 0.3;

            if (Salario < Minimo) { 
                Console.WriteLine($"Eis o valor de vosso benefício: {Aumento}");
                Console.WriteLine($"O valor somado de seu novo salário agora é: {Salario} +  {Aumento}  = {Salario + Aumento}");
            } else {
                Console.WriteLine("Sem direito ao benefício, amigo!");
            }
        }
    }
}

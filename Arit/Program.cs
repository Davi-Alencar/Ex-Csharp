using System;

namespace Arit
{
    class Program
    {
        static void Main(string[] args) 
        {
            double Nota1, Nota2, Nota3, Nota4, Média;


            Console.Write("Digite a 1ª Nota:");
            Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2ª Nota:");
            Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 3ª Nota:");
            Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 4ª Nota:");
            Nota4 = double.Parse(Console.ReadLine());

            Média = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            Console.WriteLine("Sua média é " + Média);

            if (Média >= 9) {
                Console.Write("Uau 9vin!");
            } else if ((Média >= 7) && (Média < 9)) {
                Console.Write("Não está passando nem vento, né?");
            } else {
                Console.Write("MISSION FAILED! we'll get'em next time...");
            }


            
            
        }
    }
}

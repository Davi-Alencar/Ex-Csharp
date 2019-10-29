using System;

namespace polypocket
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opcao;

            Console.WriteLine("Calcule area");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triângulo");
            Console.WriteLine("3 - Losângulo");
            Console.WriteLine("4 - Círculo");
            Console.WriteLine("5 - Trapézio");
            Console.WriteLine("6 - Retângulo");
            opcao = Console.ReadLine();

            switch(opcao) {
            
            case "1":
            Console.WriteLine("Área do Quadrado");
            Console.Write("Entre com a Base: ");
            double baseQua = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Altura: ");
            double altQua = double.Parse(Console.ReadLine());
            double = (baseQua * altQua) / 2;
            Console.WriteLine("A área do quadrado é: " + areaQua);
            break;
            
            case "2":
               Console.WriteLine("Área do Triângulo");
               Console.Write("Entre com a Base: ");
               double baseTri = double.Parse(Console.ReadLine());
               Console.Write("Entre com a Altura: ");
               double altTri = double.Parse(Console.ReadLine());
               double = (baseTri * altTri) / 2;
               Console.WriteLine("A área do triângulo é: " + areaTri);
               break;


            case "3":
            Console.WriteLine("Área do Losângulo");
            Console.Write("Entre com a Base: ");
            double baseLos = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Altura: ");
            double altLos = double.Parse(Console.ReadLine());
            double = (baseLos * altLos) / 2;
            Console.WriteLine("A área do losângulo é: " + areaLos);
            break;

            case "4":
            Console.WriteLine("Área do Círculo");
            Console.Write("Entre com a Base: ");
            double baseCir = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Altura: ");
            double altCir = double.Parse(Console.ReadLine());
            double = (baseQua * altCir) / 2;
            Console.WriteLine("A área do círculo é: " + areaCir);
            break;

            case "5":
            Console.WriteLine("Área do Trapézio");
            Console.Write("Entre com a Base: ");
            double baseTra = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Altura: ");
            double altTra = double.Parse(Console.ReadLine());
            double = (baseTra * altTra) / 2;
            Console.WriteLine("A área do trapézio é: " + areaTra);
            break;

            case "6":
            Console.WriteLine("Área do Retângulo");
            Console.Write("Entre com a Base: ");
            double baseRet = double.Parse(Console.ReadLine());
            Console.Write("Entre com a Altura: ");
            double altRet = double.Parse(Console.ReadLine());
            double = (baseRet * altRet) / 2;
            Console.WriteLine("A área do retângulo é: " + areaRet);
            break;

           }

        }
    }
}

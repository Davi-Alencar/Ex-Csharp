using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string opera;

            Console.WriteLine("Digite o 1º Número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º Número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um Operador:");
            opera = Console.ReadLine();

            
            if (opera == "+") {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }

            else if (opera == "-") {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }

            else if (opera == "*") {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }

            else if (opera == "/") {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }

            else if (opera == "%") {
                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            }

            else {
                Console.WriteLine("Operação Inválida!");
            }
            
            
            /* com suíte

            switch(opera) {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                case "%":
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");

                defou:
                    Console.WriteLine("Operação Inválida!");
                    break;

            } 
            
            
            */
            
            
            
        }
    }
}

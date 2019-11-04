using System;
using Zoo.Models;
using System.Collections.Generic;


namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            foreach(var Nome in Dicionario.DicionarioAnimal)
            {
                System.Console.WriteLine($"{opcao++} + {}");
                
            }
            
            opcao = int.Parse(Console.ReadLine());
        }
    }
}

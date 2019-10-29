using System;

namespace tabu
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++){
                for(int j = 1; j <= 10; j++){
                    Console.WriteLine($"{i,-1} x {j,+1}= {i * j, -3} ");
                }
            }
        }
    }
}

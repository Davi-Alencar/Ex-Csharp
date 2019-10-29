using System;

namespace mcdados
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cliente1 = new cliente("Jose","55 55 5555-5555","zezin@emei.com");

            Console.WriteLine("Nome: " + cliente1.nome);
            Console.WriteLine("Telefone: " + cliente1.telefone);
            Console.WriteLine("Email: " + cliente1.email);
        }
    }
}

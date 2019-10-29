using System;

namespace loginmim
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string admLogin = "admin";
            string admSenha = "admin";

            Console.Write("Usuário: ");
            string login = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if ((login == admLogin) && senha == admSenha) {
                Console.WriteLine("Well come Admin! ");
            } else {
                Console.Write("Vem vindo!");
                Console.Write(login);
            }
            
        }
    }
}

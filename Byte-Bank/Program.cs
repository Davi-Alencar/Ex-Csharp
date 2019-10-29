using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            System.Console.WriteLine("Nome: ");
            string Nome = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string Email = Console.ReadLine();
            System.Console.WriteLine("CPF: ");
            string Cpf = Console.ReadLine();

            Cliente cliente1 = new Cliente(Nome, Email, Cpf);

            bool trocouSenha = false;
            do {
                System.Console.WriteLine("Senha: ");
                string Senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(Senha);
                if (trocouSenha) {
                    System.Console.WriteLine("Senha alterada!");
                } else {
                    System.Console.WriteLine("Senha Inválida!!");
                }
            } while (!trocouSenha);
            System.Console.WriteLine();

            System.Console.WriteLine("ByteBank - Cadastro da Conta");
            System.Console.WriteLine("Entre com a Agência: ");
            int Agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com a Conta: ");
            int Conta = int.Parse(Console.ReadLine());
            

            ContaCorrente contacorrente1 = new ContaCorrente (Agencia, Conta, cliente1);
            double Saldo;
            do {
                System.Console.WriteLine("Entre com o saldo: ");
                Saldo = double.Parse(Console.ReadLine());
                if (Saldo >= 0)
                {
                    contacorrente1.Saldo = Saldo;
                } else {
                    System.Console.WriteLine("Valor do saldo deve ser positivo");
                }
                 
            } while (Saldo < 0);
            System.Console.WriteLine();

            Cliente cliente2 = new Cliente("Cesar","123.123.123-12","123@emial.com");
            ContaCorrente contacorrente2 = new ContaCorrente(123,312, cliente2);

            Cliente usuario = contacorrente1.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem-Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            System.Console.WriteLine($"Saldo {contacorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Depósito: ");
            double Valor = double.Parse(Console.ReadLine());
            contacorrente1.Deposito(Valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contacorrente1.Saldo}");
            System.Console.WriteLine();

            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem-Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            System.Console.WriteLine($"Saldo {contacorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Insira o valor do Saque: ");
            Valor = double.Parse(Console.ReadLine());
            contacorrente1.Deposito(Valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contacorrente1.Saldo}");
            System.Console.WriteLine();

            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine($"Bem-Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência {contacorrente1.Agencia} Conta: {contacorrente1.Numero}");
            System.Console.WriteLine($"Saldo {contacorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Insira o valor da Transferência: ");
            Valor = double.Parse(Console.ReadLine());
            if(contacorrente1.Transferencia(contacorrente2,Valor)) {
                System.Console.WriteLine("Transferência Efetuada");
            } else {
                System.Console.WriteLine("Não foi posível.");
            }
            contacorrente1.Deposito(Valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo Saldo: {contacorrente1.Saldo}");
            System.Console.WriteLine();


            

            string Escolha;
            
                System.Console.WriteLine("Escolha entre 1=Transferência ou 2=Saque: ");
                Escolha = Console.ReadLine();

                switch (Escolha) {
                    case "1":
                        System.Console.WriteLine("Insira um valor para Transferência: ");
                        Console.ReadLine();
                    break;

                    case "2":
                        System.Console.WriteLine("Insira um valor para Saque: ");
                        Console.ReadLine();
                    break;

                }
            
        }

        

        /* ;-; */
    }
}

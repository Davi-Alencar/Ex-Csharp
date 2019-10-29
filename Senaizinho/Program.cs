using System;

namespace Senaizinho
{
    class Program
    {
        Aluno aluno = new Aluno();
        int limiteAlunos = 10;
        int limiteSalas = 10;
        Aluno[] alunos = new Aluno[100];
        Sala [] salas = new Sala[10];
        int alunosCadastrados = 0;
        int salasCadastradas = 0;
        bool querSair;
        
        static void Main(string[] args)
        {

            
            string opcao;
            Console.Clear();
            System.Console.WriteLine("~ Bem-vindo ao Senaizin ~");
            System.Console.WriteLine();
            System.Console.WriteLine("Escolha uma das opções abaixo:");
            System.Console.WriteLine("1. Cadastrar Aluno");
            System.Console.WriteLine("2. Cadastrar Sala");
            System.Console.WriteLine("3. Alocar Aluno");
            System.Console.WriteLine("4. Remover Aluno");
            System.Console.WriteLine("5. Verificar Salas");
            System.Console.WriteLine("6. Verificar Alunos");
            System.Console.WriteLine("0. Sair");
            System.Console.Write("Opção: ");
            opcao = Console.ReadLine();
            
            
            

            switch (opcao) {
                
                case "1":
                    Console.Clear();
                    System.Console.WriteLine("Escreva seu nome: ");
                    Console.ReadLine();
                    
                    
                break;

                case "2":
                    Console.Clear();                   
                break;

                case "3":
                    Console.Clear();                   
                break;

                case "4":
                    Console.Clear();
                break;

                case "5":
                    Console.Clear();                   
                break;

                case "6":
                    Console.Clear();
                break;

                case "0":
                    Console.Clear();
                    
                break;

                default:
                    System.Console.WriteLine("Comando inválido");
                break;
            }
        
        
        }

        public void CadastrarAluno(Aluno[] alunos, int totalAluno, int aluno) {
            if (totalAluno < alunosCadastrados) 
            {
                System.Console.WriteLine("-Cadastro de Alunos-");
                System.Console.WriteLine();
                System.Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                System.Console.WriteLine("Data de Nascimento: ");
                DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAluno.Nome = nome;
                novoAluno.Nascimento = dtNascimento;

                int index = 0;

                foreach(Aluno Aluno in alunos)
                {
                    if(alunos == null)
                    {
                        alunos[index] =novoAluno;
                        break;
                    }
                    index++;
                }
                alunosCadastrados++;

            } else {
                System.Console.WriteLine("Cadastro inválido");
            }
        }

        public void CadastrarSala() {
        
        
        }

        public void AlocarAluno() {
            
        }

        public void RemoverAluno() {
            
        }

        public void VerificarSalas() {
            
        }

        public void VerificarAlunos() {
            
        }
    }
}

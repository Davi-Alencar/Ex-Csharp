using System;

namespace aluno
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno("Davi" , "456.264.909-22");
            Aluno aluno2 = new Aluno("Esquilo!" , "500.907.958-69" , "Prog1");
            Console.WriteLine("Nome: " + aluno1.nome);
            Console.WriteLine("CPF: " + aluno1.cpf);
            Console.WriteLine("Curso: " + aluno1.curso);

            Console.WriteLine("Nome: " + aluno2.nome);
            Console.WriteLine("CPF: " + aluno2.cpf);
            Console.WriteLine("Curso: " + aluno2.curso);

            Console.Write("Entre com o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Entre com o curso: ");
            string curso = Console.ReadLine();
            Console.Write("Entre ccom a nota: ");
            int nota = int.Parse(Console.ReadLine());
            Console.Write("Entre com o bimestre:" );
            int bimestre = int.Parse(Console.ReadLine());
            newclass aluno3 = new newclass(nome,cpf,curso);
            aluno3.setnotas(bimestre,nota);

            Console.WriteLine("Nome: " + aluno3.nome);
            Console.WriteLine("CPF: " + aluno3.cpf);
            Console.WriteLine("Curso: " + aluno3.curso);
            Console.WriteLine("Notas: " + aluno3.curso);
        }
    }
}
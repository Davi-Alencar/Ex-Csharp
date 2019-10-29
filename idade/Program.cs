using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;
            double resultado;

            do{
                Console.WriteLine("Digite o ano de seu nascimento! ");
                idade = double.Parse(Console.ReadLine());
                if(idade > 2019) {
                    Console.WriteLine("Saia, saia daqui, viajante do tempo!");
                }
            } while((idade > 2019) || (idade < 0));

            Console.WriteLine($"Sua idade é = {-idade + 2019} ");
            resultado = -idade + 2019;

            if(idade <= 2) {
                Console.WriteLine("Você mal saiu das fraudas... Recém-Nascido");
            } else if((resultado >=3)  && (resultado <= 11)) {
                Console.WriteLine("Lhe falta ódio. Criança");
            } else if((resultado >=12) && (resultado <= 19)) {
                Console.WriteLine("Não é uma fase! Adolescente");
            } else if(resultado == 49) {
                Console.WriteLine("Saia, saia daqui, Alexandre!");
            } else if(resultado == 32) {
                Console.WriteLine("Saia, saia daqui, César!");
            } else if((resultado >=20) && (resultado <= 65)) {
                Console.WriteLine("Já pode ser preso. Adulto");
            } else if(resultado > 65) {
                Console.WriteLine("É o fim ;-; Idoso");
            } else {
                Console.WriteLine("Mas hein?");
            }

        }
    }
}
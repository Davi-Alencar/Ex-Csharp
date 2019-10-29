using System;

namespace temperamento
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temps = new double[12];
            double maior = 0;
            double menor = 0;
            string medidaC = "C";
            string medidaF = "F";
            string medidaK = "K";
            string medida;

            Console.WriteLine("Digite uma unidade de medida: ");
            medida = Console.ReadLine();

            for (int i = 0; i < 12; i++) {
               Console.WriteLine($"Digite vossa temperatura do mês {i + 1}: ");
               temps[i] = double.Parse(Console.ReadLine());
            }
            
            maior = temps[0];
            menor = temps[0];
            string medidaC1 = medidaC;
            string medidaF1 = medidaF;
            string medidaK1 = medidaK;
            

            foreach(double temp in temps) {
                if(temp > maior) {
                    maior = temp;
                } else if(temp < menor) {
                    menor = temp;
                }

            if(medidaC1 == medidaC) {
                string medidaC2 = medidaC;
                    
            } else if(medidaF1 == medidaF) {
                string medidaF2 = medidaF;

            } else if(medidaK1 == medidaK) {
                string medidaK2 = medidaK;
;
            }

            }

            

            Console.WriteLine($"Eis a maior temperatura: {maior}{medida}");
            Console.WriteLine($"Eis a menor temperatura: {menor}{medida}");
        }
    }
}
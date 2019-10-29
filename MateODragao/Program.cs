using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                Console.Clear ();
                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("      Slay the Dragon!!");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1. Begin...");
                System.Console.WriteLine (" 0. Leave");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear();
                        
                        Guerreiro guerreiro = CriarGuerreiro();
                        string numero = Console.ReadLine();

                        

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Banguela";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /* INICIO - 1o DIALOGO */
                        CriarDialogo(guerreiro.Nome, $": {dragao.Nome}, sua bixa pão-com-ovo!");
                        CriarDialogo(dragao.Nome, $": ;-;");
                        
                        FinalizarDialogo();
                        /* FIM - 1o DIALOGO */

                        /* INICIO - 2o DIALOGO */
                        Console.Clear();
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Filho de {guerreiro.Sobrenome}, ó criatura diabética!");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vindo da cidade de {guerreiro.CidadeNatal} para descer-lhe à porrada!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Ãhn?! Hein?!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Hit ENTER to continue");
                        Console.ReadLine();
                        /* FIM - 2o DIALOGO */

                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;
                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine($"~{guerreiro.Nome}'s Turn~");
                            System.Console.WriteLine("Make Your Move:");
                            System.Console.WriteLine(" 1. Charge!");
                            System.Console.WriteLine(" 2. Run!");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador) 
                            {
                                case "1":
                                    Console.Clear();
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) 
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Wapow!!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP {dragao.Nome}: {dragao.Vida}");
                                        System.Console.WriteLine($"HP {guerreiro.Nome}: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: A swing and a miss...");
                                    }

                                break;

                                case "2":
                                    Console.Clear();
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Well I'll be hauling ass!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: pussyass..");
                                    jogadorNaoCorreu = false;
                                break;
                            }

                        }

                        Console.Clear();
                        System.Console.WriteLine();
                        System.Console.WriteLine("Hit ENTER to continue");
                        Console.ReadLine();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu) 
                        {
                            Console.Clear();
                            System.Console.WriteLine($"~{dragao.Nome}'s Turn~");

                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (guerreiroDestrezaTotal < dragaoDestrezaTotal) 
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Toasty!");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP {dragao.Nome}: {dragao.Vida}");
                                System.Console.WriteLine($"HP {guerreiro.Nome}: {guerreiro.Vida}");
                            }
                            else
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Big lizard doesn't want no hugs ;-;");
                            }    

                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("Hit ENTER to continue");
                        Console.ReadLine();
                        /* */

                        Console.Clear();

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine();
                            System.Console.WriteLine("Hit ENTER to continue");
                            Console.ReadLine();

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador) 
                            {
                                case "1":
                                    Console.Clear();
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) 
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Wapow!!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP {dragao.Nome}: {dragao.Vida}");
                                        System.Console.WriteLine($"HP {guerreiro.Nome}: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: A swing and a miss...");
                                    }

                                break;

                                case "2":
                                    Console.Clear();
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Well I'll be hauling ass!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: pussyass..");
                                    jogadorNaoCorreu = false;
                                break;
                            }

                        }

                            if (guerreiro.Vida <= 0)
                            {
                                System.Console.WriteLine("Perished..");
                            }

                            if (dragao.Vida <= 0)
                            {
                                System.Console.WriteLine("Victory!");
                            }

                        break;

                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("ded");
                        break;

                    default:
                        System.Console.WriteLine ("Error404");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }

        public static void CriarDialogo(string nome, string frase) 
        {
            System.Console.WriteLine($"{nome.ToUpper()}:\n{frase}");
        }

        public static void FinalizarDialogo() {
            System.Console.WriteLine();
            System.Console.WriteLine("Hit ENTER to continue");
        }

        public static Guerreiro CriarGuerreiro() {
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "João";
            guerreiro.Sobrenome = "Bobão";
            guerreiro.CidadeNatal = "IorqueNova";
            guerreiro.DataNascimento = DateTime.Parse("17/01/1302");
            guerreiro.FerramentadeProtecao = "Escudo"; 
            guerreiro.FerramentadeAtaque = "Lança";
            guerreiro.Forca = 5;
            guerreiro.Destreza = 2;
            guerreiro.Inteligencia = 1;
            guerreiro.Vida = 20;

            return guerreiro; 
        }
    }
}

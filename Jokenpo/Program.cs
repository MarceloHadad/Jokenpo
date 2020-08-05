using System;
using Jokenpo.Entities;
using Jokenpo.Services;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            JogarService jogar = new JogarService();

            Console.WriteLine("Entre com o nome do Jogador 1: ");
            j1.name = Console.ReadLine();

            Console.WriteLine("Entre com o nome do Jogador 2: ");
            j2.name = Console.ReadLine();

            Console.WriteLine("Escolham uma das opções\n" +
                "1 - Pedra\n" +
                "2 - Papel\n" +
                "3 - Tesoura");

            Console.WriteLine("Opção do Jogador 1: ");
            j1.opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Opção do Jogador 2: ");
            j2.opcao = int.Parse(Console.ReadLine());

            jogar.Jokenpo(j1.name, j1.opcao, j2.name, j2.opcao);
            jogar.ToString();

            Console.WriteLine();
            Console.WriteLine(jogar.ToString());
        }
    }
}

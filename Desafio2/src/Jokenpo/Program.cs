using System;
using System.Collections.Generic;
using Bogus;
using Jokenpo.Entities;
using Jokenpo.Util;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker();

            var bot = new Jogador(nome: faker.Name.FullName());

            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de partidas que você quer:");
            var qtdPartidas = Convert.ToInt32(Console.ReadLine());

            var jogador = new Jogador(nome);

            var jogo = new Jogo(jogador, bot);

            Console.WriteLine("\nO jogo iniciou!!");

            Console.WriteLine($"O seu oponente será: {bot.Nome}!");

            var partidas = new List<Partida>();

            for (int i = 1; i <= qtdPartidas; i++)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Tesoura");
                Console.WriteLine("2 - Papel");
                Console.WriteLine("3 - Pedra\n");

                Opcoes jogadaDoJogador;
                var opcaoEscolhida = Console.ReadLine();

                Console.WriteLine("\n");

                switch (opcaoEscolhida.ToLower())
                {
                    case "1":
                    case "tesoura":
                        jogadaDoJogador = Opcoes.Tesoura;
                        break;
                    case "2":
                    case "papel":
                        jogadaDoJogador = Opcoes.Papel;
                        break;
                    case "3":
                    case "pedra":
                    default:
                        jogadaDoJogador = Opcoes.Pedra;
                        break;
                }

                var jogadaDoBot = (Opcoes)new Random().Next(minValue: 0, maxValue: 2);

                var partida = new Partida(jogador1: jogadaDoJogador, jogador2: jogadaDoBot);

                Console.WriteLine($"{jogador.Nome} colocou {jogadaDoJogador}!");
                Console.WriteLine($"{bot.Nome} colocou {jogadaDoBot}!");

                Console.WriteLine($"-> Resultado da {i}º partida: {partida.Resultado}\n");

                partidas.Add(partida);
            }

            jogo.Duelar(partidas);

            switch (jogo.Resultado)
            {
                case Resultados.Jogador1:
                    Console.WriteLine($"-> Parabens!! Você ganhou o jogo.");
                    break;
                case Resultados.Jogador2:
                    Console.WriteLine($"-> Que pena! Você perdeu.");
                    break;
                default:
                case Resultados.Empate:
                    Console.WriteLine($"-> Quaase! O jogo empatou.");
                    break;
            }
            
        }
    }
}

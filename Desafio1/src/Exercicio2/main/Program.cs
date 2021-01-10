using System;
using System.Collections.Generic;
using Exercicio2.model;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            var livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            var games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            var americanas= new Loja("Americanas","12345678",livros,games);
            l1.ImprimirImposto();
            l2.ImprimirImposto();
            l3.ImprimirImposto();
            ps4Usado.ImprimirImposto();
            ps4.ImprimirImposto();
            System.Console.WriteLine("-----------------------------------------------");
            americanas.ListaLivros();
            americanas.ListaVideoGames();
            americanas.CalculaPatrimonio();
            System.Console.WriteLine($"O patrimonio da loja: {americanas.nome} é de R${americanas.CalculaPatrimonio()}");
        }
    }
}

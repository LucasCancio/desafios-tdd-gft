using System.Collections.Generic;
using Exercicio2.util;

namespace Exercicio2.model
{
    public class Loja
    {
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;
        }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public List<Livro> livros { get; set; }
        public List<VideoGame> videoGames { get; set; }

        public void ListaLivros()
        {
            System.Console.WriteLine($"A loja {this.nome} possui estes livros para venda:");
            if (this.livros.Count == 0) throw new EstoqueVazioException("A loja não tem livros no seu estoque.");

            this.livros.ForEach(livro => System.Console.WriteLine(livro.ToString()));
            System.Console.WriteLine("-----------------------------------------------");
        }

        public void ListaVideoGames()
        {
            System.Console.WriteLine($"A loja {this.nome} possui estes video-games para venda:");
            if (this.livros.Count == 0) throw new EstoqueVazioException("A loja não tem video-games no seu estoque.");

            this.videoGames.ForEach(videoGame => System.Console.WriteLine(videoGame.ToString()));
            System.Console.WriteLine("-----------------------------------------------");
        }

        public double CalculaPatrimonio()
        {
            double valorTotal = 0;

            this.livros.ForEach(livro =>
            {
                valorTotal += livro.preco * livro.qtd;
            });

            this.videoGames.ForEach(videoGame =>
            {
                valorTotal += videoGame.preco * videoGame.qtd;
            });

            return valorTotal;
        }
    }
}
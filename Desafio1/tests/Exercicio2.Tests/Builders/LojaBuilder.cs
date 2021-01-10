using System.Collections.Generic;
using Bogus;
using Exercicio2.model;

namespace Exercicio2.Tests.Builders
{
    public class LojaBuilder
    {
        private string _nome;
        private string _cnpj;
        private List<Livro> _livros;
        private List<VideoGame> _videoGames;
        public static LojaBuilder Novo()
        {
            return new LojaBuilder();
        }

        public LojaBuilder()
        {
            var faker = new Faker();
            _nome = faker.Company.CompanyName();
            _cnpj = faker.Random.Word();

            _livros = new List<Livro>();
            _videoGames = new List<VideoGame>();
        }

        public LojaBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public LojaBuilder ComCnpj(string cnpj)
        {
            _cnpj = cnpj;
            return this;
        }

        public LojaBuilder ComLivros(List<Livro> livros)
        {
            _livros = livros;
            return this;
        }

        public LojaBuilder ComVideoGames(List<VideoGame> videoGames)
        {
            _videoGames = videoGames;
            return this;
        }

        public Loja Construir()
        {
            return new Loja(_nome, _cnpj, _livros, _videoGames);
        }

    }
}
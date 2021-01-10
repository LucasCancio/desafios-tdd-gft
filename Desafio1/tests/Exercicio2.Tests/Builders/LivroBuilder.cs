using Bogus;
using Exercicio2.model;

namespace Exercicio2.Tests.Builders
{
    public class LivroBuilder
    {
        private string _nome;
        private double _preco;
        private int _qtd;
        private string _autor;
        private string _tema;
        private int _qtdPag;
        public static LivroBuilder Novo()
        {
            return new LivroBuilder();
        }

        public LivroBuilder()
        {
            var faker = new Faker();
            _nome = faker.Commerce.ProductName();
            _preco = faker.Random.Double(1, 100);
            _qtd = faker.Random.Int(1, 100);
            _autor = faker.Name.FullName();
            _tema = faker.Lorem.Word();
            _qtdPag = faker.Random.Int(1, 100);
        }

        public LivroBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public LivroBuilder ComPreco(double preco)
        {
            _preco = preco;
            return this;
        }

        public LivroBuilder ComQtd(int qtd)
        {
            _qtd = qtd;
            return this;
        }

        public LivroBuilder ComAutor(string autor)
        {
            _autor = autor;
            return this;
        }

        public LivroBuilder ComTema(string tema)
        {
            _tema = tema;
            return this;
        }

        public LivroBuilder ComQtdPag(int qtdPag)
        {
            _qtdPag = qtdPag;
            return this;
        }


        public Livro ConstruirBasico()
        {
            return new Livro(_nome, _preco, _qtd);
        }

        public Livro ConstruirCompleto()
        {
            return new Livro(_nome, _preco, _qtd, _autor, _tema, _qtdPag);
        }
    }
}
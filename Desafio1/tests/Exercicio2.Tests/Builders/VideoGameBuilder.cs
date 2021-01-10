using Bogus;
using Exercicio2.model;

namespace Exercicio2.Tests.Builders
{
    public class VideoGameBuilder
    {
        private string _nome;
        private double _preco;
        private int _qtd;
        private string _marca;
        private string _modelo;
        private bool _isUsado;
        public static VideoGameBuilder Novo()
        {
            return new VideoGameBuilder();
        }

        public VideoGameBuilder()
        {
            var faker = new Faker();
            _nome = faker.Commerce.ProductName();
            _preco = faker.Random.Double(1, 100);
            _qtd = faker.Random.Int(1, 100);
            _marca = faker.Random.Word();
            _modelo = faker.Random.Word();
            _isUsado = faker.Random.Bool();
        }

        public VideoGameBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public VideoGameBuilder ComPreco(double preco)
        {
            _preco = preco;
            return this;
        }

        public VideoGameBuilder ComQtd(int qtd)
        {
            _qtd = qtd;
            return this;
        }

        public VideoGameBuilder ComMarca(string marca)
        {
            _marca = marca;
            return this;
        }

        public VideoGameBuilder ComModelo(string modelo)
        {
            _modelo = modelo;
            return this;
        }

        public VideoGameBuilder Usado(bool status)
        {
            _isUsado = status;
            return this;
        }



        public VideoGame ConstruirBasico()
        {
            return new VideoGame(_nome, _preco, _qtd);
        }

        public VideoGame ConstruirCompleto()
        {
            return new VideoGame(_nome, _preco, _qtd, _marca, _modelo, _isUsado);
        }
    }
}
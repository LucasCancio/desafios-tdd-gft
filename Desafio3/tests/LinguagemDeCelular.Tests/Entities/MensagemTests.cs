using System;
using Bogus;
using LinguagemDeCelular.Entities;
using Xunit;

namespace LinguagemDeCelular.Tests.Entities
{
    public class MensagemTests
    {
        private readonly Mensagem mensagemValida;
        private readonly Faker faker;
        public MensagemTests()
        {
            faker = new Faker();
            var palavraAleatoria = faker.Random.Word();
            if (palavraAleatoria.Length > 255)
            {
                palavraAleatoria.Substring(0, 254);
            }
            mensagemValida = new Mensagem(texto: palavraAleatoria);
        }


        [Fact]
        public void Mensagem__deve_retornar_erro__quando_texto_ter_mais_de_255_caracteres()
        {
            Assert.Throws<ArgumentException>(() =>
             new Mensagem(faker.Random.String(length: 256))
            );
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Mensagem__deve_retornar_erro__quando_texto_estiver_vazio_ou_nulo(string texto)
        {
            Assert.Throws<ArgumentException>(() =>
             new Mensagem(texto)
            );
        }
    }
}
using Exercicio2.model;
using Exercicio2.Tests.Builders;
using Xunit;

namespace Exercicio2.Tests.model
{
    public class VideoGameTests
    {
        [Fact]
        public void CalcularImposto_de_videogame_usado__deve_retornar_25porcento_do_preco()
        {
            VideoGame videoGame = VideoGameBuilder.Novo().Usado(true).ConstruirCompleto();
            var imposto = videoGame.CalculaImposto();
            var valorDe25porCento = videoGame.preco * 0.25;

            Assert.Equal(expected: valorDe25porCento, actual: imposto);
        }

        [Fact]
        public void CalcularImposto_de_videogame_novo__deve_retornar_45porcento_do_preco()
        {
            VideoGame videoGame = VideoGameBuilder.Novo().Usado(false).ConstruirCompleto();
            var imposto = videoGame.CalculaImposto();
            var valorDe45porCento = videoGame.preco * 0.45;

            Assert.Equal(expected: valorDe45porCento, actual: imposto);
        }
    }
}
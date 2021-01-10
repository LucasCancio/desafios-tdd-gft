using Exercicio2.model;
using Exercicio2.Tests.Builders;
using Xunit;

namespace Exercicio2.Tests.model
{
    public class LivroTests
    {
        [Fact]
        public void CalcularImposto_de_livro_com_tema_educativo__deve_retornar_0()
        {
            Livro livro = LivroBuilder.Novo().ComTema("Educativo").ConstruirCompleto();
            var imposto = livro.CalculaImposto();

            Assert.Equal(expected: 0, actual: imposto);
        }

        [Fact]
        public void CalcularImposto_de_livro_com_outros_temas__deve_retornar_10porcento_do_preco()
        {
            Livro livro = LivroBuilder.Novo().ConstruirCompleto();
            var imposto = livro.CalculaImposto();
            var valorDe10porCento = livro.preco * 0.1;

            Assert.Equal(expected: valorDe10porCento, actual: imposto);
        }
    }
}
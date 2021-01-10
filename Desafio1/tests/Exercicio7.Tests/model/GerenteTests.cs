using Exercicio7.model;
using Exercicio7.Tests.Builders;
using Xunit;

namespace Exercicio7.Tests.model
{
    public class GerenteTests
    {
        [Fact]
        public void Bonificacao__deve_retornar_salario_mais_10_mil()
        {
            Gerente gerente = FuncionarioBuilder<Gerente>.Novo().Construir();

            Assert.Equal(expected: gerente.salario + 10_000.00, actual: gerente.Bonificacao());
        }
    }
}
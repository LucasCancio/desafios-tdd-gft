using Exercicio7.model;
using Exercicio7.Tests.Builders;
using Xunit;

namespace Exercicio7.Tests.model
{
    public class VendedorTests
    {
        [Fact]
        public void Bonificacao__deve_retornar_salario_mais_3_mil()
        {
            Vendedor vendedor = FuncionarioBuilder<Vendedor>.Novo().Construir();

            Assert.Equal(expected: vendedor.salario + 3_000.00, actual: vendedor.Bonificacao());
        }
    }
}
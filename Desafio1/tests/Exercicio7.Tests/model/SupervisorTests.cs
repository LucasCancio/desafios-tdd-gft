using Exercicio7.model;
using Exercicio7.Tests.Builders;
using Xunit;

namespace Exercicio7.Tests.model
{
    public class SupervisorTests
    {
        [Fact]
        public void Bonificacao__deve_retornar_salario_mais_5_mil()
        {
            Supervisor supervisor = FuncionarioBuilder<Supervisor>.Novo().Construir();

            Assert.Equal(expected: supervisor.salario + 5_000.00, actual: supervisor.Bonificacao());
        }
    }
}
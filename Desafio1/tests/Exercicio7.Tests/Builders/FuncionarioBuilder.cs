using Bogus;
using Exercicio7.model;

namespace Exercicio7.Tests.Builders
{
    public class FuncionarioBuilder<T> where T : Funcionario
    {
        private string _nome;
        private int _idade;
        private double _salario;

        public static FuncionarioBuilder<T> Novo()
        {
            return new FuncionarioBuilder<T>();
        }

        public FuncionarioBuilder()
        {
            var faker = new Faker();
            _nome = faker.Name.FullName();
            _idade = faker.Random.Int(18, 80);
            _salario = faker.Random.Double(1_000, 100_000);
        }

        public FuncionarioBuilder<T> ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public FuncionarioBuilder<T> ComIdade(int idade)
        {
            _idade = idade;
            return this;
        }

        public FuncionarioBuilder<T> ComSalario(double salario)
        {
            _salario = salario;
            return this;
        }

        public T Construir()
        {
            if (typeof(T) == typeof(Gerente))
            {
                return new Gerente(_nome, _idade, _salario) as T;
            }
            
            if (typeof(T) == typeof(Vendedor))
            {
                return new Vendedor(_nome, _idade, _salario) as T;
            }

            return new Supervisor(_nome, _idade, _salario) as T;
        }
    }
}
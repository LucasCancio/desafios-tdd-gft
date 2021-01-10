namespace Exercicio7.model
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public const double ACRESCIMO_BONIFICACAO= 10_000.00;
        public override double Bonificacao(){
            return base.Bonificacao() + ACRESCIMO_BONIFICACAO;
        }
    }
}
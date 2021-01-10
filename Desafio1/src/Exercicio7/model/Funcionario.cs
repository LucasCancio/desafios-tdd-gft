using System;

namespace Exercicio7.model
{
    public abstract class Funcionario
    {
        public Funcionario(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
        }
        public string nome { get; private set; }
        public int idade { get; private set; }
        public double salario { get; private set; }

        public virtual double Bonificacao()
        {
            return this.salario;
        }

        public void Imprimir(){
            Console.WriteLine($"Nome: {this.nome}, Idade: {this.idade}, Salario (com bonificação): {this.Bonificacao()}, Cargo: {this.GetType().Name}");
        }
    }
}
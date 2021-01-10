using System;
using Exercicio4.model;
using System.Linq;
using System.Collections.Generic;
using Exercicio4_5_6.Helper;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = new List<Pessoa>(){
            new Pessoa("João",15),
            new Pessoa("Leandro",21),
            new Pessoa("Paulo",17),
            new Pessoa("Jessica",18),
        };
            Pessoa pessoaMaisVelha = PessoaHelper.GetPessoaMaisVelha(pessoas);
            System.Console.WriteLine($"A pessoa mais velha, é a(o) {pessoaMaisVelha.nome}, com {pessoaMaisVelha.idade} anos");

            System.Console.WriteLine($"Total de pessoas: {pessoas.Count}");

            var idadeMinima = 18;
            List<Pessoa> maioresDeIdade = PessoaHelper.FiltrarPorIdadeMinima(pessoas, idadeMinima);

            System.Console.WriteLine($"Total de pessoas com idade superior, ou igual à {idadeMinima} anos: {maioresDeIdade.Count}");

            var nomePraEncontrar = "jessica";
            List<Pessoa> pessoasComDeterminadoNome = PessoaHelper.BuscarPorNome(pessoas, nomePraEncontrar);
            if (pessoasComDeterminadoNome != null && pessoasComDeterminadoNome.Count != 0)
            {
                foreach (Pessoa pessoa in pessoasComDeterminadoNome)
                {
                    System.Console.WriteLine($"A {pessoa.nome}, possui {pessoa.idade} anos!");
                }
            }
            else
            {
                System.Console.WriteLine($"Não existe nenhuma pessoa com nome {nomePraEncontrar}, na lista!");
            }
        }
    }

}

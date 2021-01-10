using System;
using System.Collections.Generic;
using System.Linq;
using Exercicio4.model;

namespace Exercicio4_5_6.Helper
{
    public static class PessoaHelper
    {
        public static Pessoa GetPessoaMaisVelha(List<Pessoa> pessoas)
        {
            return pessoas.OrderByDescending(p => p.idade).FirstOrDefault();
        }

        public static List<Pessoa> FiltrarPorIdadeMinima(List<Pessoa> pessoas, int idadeMinima)
        {
            if (idadeMinima <= 0) throw new ArgumentException("Idade não pode ser menor ou igual a 0!");

            return pessoas.Where(p => p.idade >= idadeMinima).ToList();
        }

        public static List<Pessoa> BuscarPorNome(List<Pessoa> pessoas, string nome)
        {
            if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome não pode ser vazio!");

            return pessoas
                        .Where(p =>
                                    p.nome.Contains(nome, StringComparison.CurrentCultureIgnoreCase)
                        )
                        .ToList();
        }
    }
}
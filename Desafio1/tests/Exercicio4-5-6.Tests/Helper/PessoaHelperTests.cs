using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Exercicio4.model;
using Exercicio4_5_6.Helper;
using Xunit;

namespace Exercicio4_5_6.Tests.Helper
{
    public class PessoaHelperTests
    {
        private List<Pessoa> pessoas;
        public PessoaHelperTests()
        {
            pessoas = new List<Pessoa>(){
                new Pessoa("Joao",15),
                new Pessoa("Jose",35),
                new Pessoa("Leandro",21),
                new Pessoa("Paulo",17),
                new Pessoa("Jessica",18),
                new Pessoa("Maria Jose",56),
            };
        }
        [Fact]
        public void GetPessoaMaisVelha__deve_retornar_a_pessoa_com_mais_idade()
        {
            var pessoaMaisVelha = PessoaHelper.GetPessoaMaisVelha(pessoas);

            Assert.Equal(expected: "Maria Jose", actual: pessoaMaisVelha.nome);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void FiltrarPorIdadeMinima__deve_retornar_erro__quando_idade_estiver_invalida(int idadeInvalida)
        {
            Assert.Throws<ArgumentException>(() => PessoaHelper.FiltrarPorIdadeMinima(pessoas, idadeInvalida));
        }

        [Theory]
        [ClassData(typeof(IdadeMinimaTestData))]
        public void FiltrarPorIdadeMinima__deve_retornar_apenas_quem_tem_idade_maior_ou_igual_a(int idade, List<string> nomesEsperados)
        {
            var pessoasFiltradas = PessoaHelper.FiltrarPorIdadeMinima(pessoas, idade);
            var nomesEncontrados = pessoasFiltradas.Select(x => x.nome).ToList();

            Assert.Equal(expected: nomesEsperados.Count, actual: nomesEncontrados.Count);
            Assert.False(nomesEncontrados.Except(nomesEsperados).Any());
        }


        [Theory]
        [ClassData(typeof(BuscarPorNomeTestData))]
        public void BuscarPorNome__deve_retornar_apenas_quem_tem_nome_igual_a(string nome, List<string> nomesEsperados)
        {
            var pessoasFiltradas = PessoaHelper.BuscarPorNome(pessoas, nome);
            var nomesEncontrados = pessoasFiltradas.Select(x => x.nome).ToList();

            Assert.Equal(expected: nomesEsperados.Count, actual: nomesEncontrados.Count);
            Assert.False(nomesEncontrados.Except(nomesEsperados).Any());
        }

        [Fact]
        public void BuscarPorNome__deve_retornar_erro__quando_nome_estiver_vazio()
        {
            Assert.Throws<ArgumentException>(() => PessoaHelper.BuscarPorNome(pessoas, ""));
        }
    }

    class IdadeMinimaTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 18, new List<string> { "Jose", "Jessica", "Leandro", "Maria Jose" } };
            yield return new object[] { 30, new List<string> { "Jose", "Maria Jose" } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class BuscarPorNomeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "Jose", new List<string> { "Jose", "Maria Jose" } };
            yield return new object[] { "jessica", new List<string> { "Jessica" } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
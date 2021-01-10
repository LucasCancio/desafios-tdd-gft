using Jokenpo.Entities;
using Jokenpo.Util;
using Xunit;

namespace Jokenpo.Tests.Entities
{
    public class PartidaTests
    {
        [Fact]
        public void Pedra_deve_ganhar_de_tesoura()
        {
            var partida = new Partida(jogador1: Opcoes.Pedra, jogador2: Opcoes.Tesoura);
            Assert.Equal(expected: Resultados.Jogador1, actual: partida.Resultado);
        }

        [Fact]
        public void Pedra_deve_empatar_com_pedra()
        {
            var partida = new Partida(jogador1: Opcoes.Pedra, jogador2: Opcoes.Pedra);
            Assert.Equal(expected: Resultados.Empate, actual: partida.Resultado);
        }

        [Fact]
        public void Tesoura_deve_ganhar_de_papel()
        {
            var partida = new Partida(jogador1: Opcoes.Tesoura, jogador2: Opcoes.Papel);
            Assert.Equal(expected: Resultados.Jogador1, actual: partida.Resultado);
        }

        [Fact]
        public void Tesoura_deve_empatar_com_tesoura()
        {
            var partida = new Partida(jogador1: Opcoes.Tesoura, jogador2: Opcoes.Tesoura);
            Assert.Equal(expected: Resultados.Empate, actual: partida.Resultado);
        }

        [Fact]
        public void Papel_deve_ganhar_de_pedra()
        {
            var partida = new Partida(jogador1: Opcoes.Pedra, jogador2: Opcoes.Papel);
            Assert.Equal(expected: Resultados.Jogador2, actual: partida.Resultado);
        }

        [Fact]
        public void Papel_deve_empatar_com_papel()
        {
            var partida = new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Papel);
            Assert.Equal(expected: Resultados.Empate, actual: partida.Resultado);
        }
    }
}
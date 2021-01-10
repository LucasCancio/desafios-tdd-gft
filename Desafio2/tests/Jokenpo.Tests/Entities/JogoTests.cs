using Jokenpo.Entities;
using Jokenpo.Util;
using Xunit;

namespace Jokenpo.Tests.Entities
{
    public class JogoTests
    {
        private Jogador jogador1;
        private Jogador jogador2;
        private Jogo jogo;

        public JogoTests()
        {
            jogador1 = new Jogador("Jorge");
            jogador2 = new Jogador("Jose");
            jogo = new Jogo(jogador1, jogador2);
        }

        [Fact]
        public void Duelar__deve_retornar_vencedor_Jogador1__quando_Jogador1_vencer()
        {
            jogo.Duelar(
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Pedra)
            );

            Assert.Equal(expected: Resultados.Jogador1, actual: jogo.Resultado);
        }

        [Fact]
        public void Duelar__deve_retornar_vencedor_Jogador2__quando_Jogador1_perder()
        {
            jogo.Duelar(
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Tesoura)
            );

            Assert.Equal(expected: Resultados.Jogador2, actual: jogo.Resultado);
        }

        [Fact]
        public void Duelar__deve_retornar_empate__quando_jogo_empatar()
        {
            jogo.Duelar(
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Papel)
            );

            Assert.Equal(expected: Resultados.Empate, actual: jogo.Resultado);
        }

        [Fact]
        public void Duelar__deve_retornar_Jogador1__quando_Jogador1_ganhar_em_melhor_de_3()
        {
            jogo.Duelar(
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Pedra),
                new Partida(jogador1: Opcoes.Tesoura, jogador2: Opcoes.Papel),
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Papel)
            );

            Assert.Equal(expected: Resultados.Jogador1, actual: jogo.Resultado);
        }

        [Fact]
        public void Duelar__deve_retornar_Jogador2__quando_Jogador2_ganhar_em_melhor_de_5()
        {
            jogo.Duelar(
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Pedra),
                new Partida(jogador1: Opcoes.Tesoura, jogador2: Opcoes.Papel),
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Tesoura),
                new Partida(jogador1: Opcoes.Pedra, jogador2: Opcoes.Papel),
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Tesoura)
            );

            Assert.Equal(expected: Resultados.Jogador2, actual: jogo.Resultado);
        }

        [Fact]
        public void Duelar__deve_retornar_empate__quando_jogo_empatar_em_melhor_de_5()
        {
            jogo.Duelar(
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Pedra),
                new Partida(jogador1: Opcoes.Tesoura, jogador2: Opcoes.Papel),
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Tesoura),
                new Partida(jogador1: Opcoes.Pedra, jogador2: Opcoes.Papel),
                new Partida(jogador1: Opcoes.Papel, jogador2: Opcoes.Papel)
            );

            Assert.Equal(expected: Resultados.Empate, actual: jogo.Resultado);
        }
    }
}
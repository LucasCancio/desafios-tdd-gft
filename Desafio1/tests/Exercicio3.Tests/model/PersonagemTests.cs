using Exercicio3.model;
using Exercicio3.Tests.Builders;
using Xunit;

namespace Exercicio3.Tests.model
{
    public class PersonagemTests
    {
        [Fact]
        public void ReceberAtaque__deve_tirar_vida_do_personagem()
        {
            Personagem personagem = MagoBuilder.Novo().ComVida(100).Construir();
            personagem.ReceberAtaque(10);

            Assert.Equal(expected: 90, actual: personagem.vida);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        public void ReceberAtaque__deve_matar_o_personagem__quando_o_ataque_ser_maior_ou_igual_a_vida(int dano)
        {
            Personagem personagem = MagoBuilder.Novo().ComVida(10).Construir();
            personagem.ReceberAtaque(dano);

            Assert.False(personagem.estaVivo);
        }

        [Fact]
        public void ReceberAtaque__nao_deve_tirar_vida__quando_o_personagem_ja_esta_morto()
        {
            Personagem personagem = MagoBuilder.Novo().ComVida(10).Construir();
            personagem.ReceberAtaque(10);
            personagem.ReceberAtaque(2);


            Assert.True(personagem.vida >= 0);
        }

        [Fact]
        public void TomarPocaoDeVida__deve_recuperar_toda_a_vida()
        {
            Personagem personagem = MagoBuilder.Novo().ComVida(100).Construir();
            personagem.ReceberAtaque(10);

            personagem.TomarPocaoDeVida();

            Assert.True(personagem.maxVida == personagem.vida);
        }
    }
}
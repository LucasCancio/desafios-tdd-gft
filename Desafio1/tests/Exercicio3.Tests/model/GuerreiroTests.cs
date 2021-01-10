using System;
using Exercicio3.model;
using Exercicio3.Tests.Builders;
using Xunit;

namespace Exercicio3.Tests.model
{
    public class GuerreiroTests
    {
        [Fact]
        public void LvlUp__deve_evoluir_atributos_sendo_mais_vida_e_forca()
        {
            Guerreiro guerreiro = GuerreiroBuilder.Novo().Construir();
            Guerreiro guerreiroEvoluido = guerreiro.Clone();
            guerreiroEvoluido.LvlUp();

            Assert.True(guerreiroEvoluido.mana == guerreiro.mana + 1);
            Assert.True(guerreiroEvoluido.inteligencia == guerreiro.inteligencia + 1);
            Assert.True(guerreiroEvoluido.level == guerreiro.level + 1);

            Assert.True(guerreiroEvoluido.vida == guerreiro.vida + 2);
            Assert.True(guerreiroEvoluido.forca == guerreiro.forca + 2);
        }

        [Fact]
        public void AprenderHabilidade__deve_dar_erro__quando_habilidade_estiver_vazia()
        {
            Guerreiro guerreiro = GuerreiroBuilder.Novo().Construir();
            var habilidade = string.Empty;

            Assert.Throws<ArgumentException>(() => guerreiro.AprenderHabilidade(habilidade));
        }

        [Fact]
        public void AprenderHabilidade__deve_adicionar_habilidade_na_lista_de_habilidades()
        {
            Guerreiro guerreiro = GuerreiroBuilder.Novo().Construir();
            var habilidade = "Habilidade Teste";
            guerreiro.AprenderHabilidade(habilidade);

            Assert.Contains(guerreiro.habilidades, h => h == habilidade);
        }

        [Fact]
        public void Attack__deve_retornar_dano_entre_0_e_300_somado_com_forca_vezes_level()
        {
            Guerreiro guerreiro = GuerreiroBuilder.Novo().Construir();
            var ataqueBase = guerreiro.forca * guerreiro.level;
            var ataque = guerreiro.Attack();

            Assert.True(ataque > 0);
            Assert.True(ataque >= ataqueBase);
            Assert.True(ataque <= (300 + ataqueBase));
        }

        [Fact]
        public void Qtd_de_guerreiros__deve_ser_2()
        {
            Guerreiro guerreiro1 = GuerreiroBuilder.Novo().Construir();
            Guerreiro guerreiro2 = GuerreiroBuilder.Novo().Construir();

            Assert.Equal(expected: 2, actual: Guerreiro.qtde);
        }
    }
}
using System;
using Exercicio3.model;
using Exercicio3.Tests.Builders;
using Xunit;

namespace Exercicio3.Tests.model
{
    public class MagoTests
    {
        [Fact]
        public void LvlUp__deve_evoluir_atributos_sendo_mais_mana_e_inteligencia()
        {
            Mago mago = MagoBuilder.Novo().Construir();
            Mago magoEvoluido = mago.Clone();
            magoEvoluido.LvlUp();
            
            Assert.True(magoEvoluido.vida == mago.vida + 1);
            Assert.True(magoEvoluido.forca == mago.forca + 1);
            Assert.True(magoEvoluido.level == mago.level + 1);

            Assert.True(magoEvoluido.mana == mago.mana + 2);
            Assert.True(magoEvoluido.inteligencia == mago.inteligencia + 2);
        }

        [Fact]
        public void AprenderMagia__deve_adicionar_magia_na_lista_de_magias()
        {
            Mago mago = MagoBuilder.Novo().Construir();
            var magia = "Magia Teste";
            mago.AprenderMagia(magia);

            Assert.Contains(mago.magias, m => m == magia);
        }

        [Fact]
        public void AprenderMagia__deve_dar_erro__quando_magia_estiver_vazia()
        {
            Mago mago = MagoBuilder.Novo().Construir();
            var magia = string.Empty;

            Assert.Throws<ArgumentException>(() => mago.AprenderMagia(magia));
        }

        [Fact]
        public void Attack__deve_retornar_dano_entre_0_e_300_somado_com_inteligencia_vezes_level()
        {
            Mago mago = MagoBuilder.Novo().Construir();
            var ataqueBase = mago.inteligencia * mago.level;
            var ataque = mago.Attack();

            Assert.True(ataque > 0);
            Assert.True(ataque >= ataqueBase);
            Assert.True(ataque <= (300 + ataqueBase));
        }

        [Fact]
        public void Qtd_de_magos__deve_ser_2()
        {
            Mago mago1 = MagoBuilder.Novo().Construir();
            Mago mago2 = MagoBuilder.Novo().Construir();

            Assert.Equal(expected: 2, actual: Mago.qtde);
        }

    }
}
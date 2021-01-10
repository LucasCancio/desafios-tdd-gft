using System;
using Exercicio1.Builders;
using Exercicio1.util;
using Xunit;

namespace Exercicio1
{
    public class VeiculoTests
    {
        private readonly Veiculo veiculoValido;
        public VeiculoTests()
        {
            veiculoValido = VeiculoBuilder.Novo().Construir();
        }

        [Fact]
        public void Ligar_um_veiculo_desligado__deve_ligar_o_veiculo()
        {
            veiculoValido.Ligar();
            Assert.True(veiculoValido.isLigado);
        }

        [Fact]
        public void Ligar_um_veiculo_ja_ligado__nao_deve_desligar_o_veiculo()
        {
            veiculoValido.Ligar();
            veiculoValido.Ligar();

            Assert.True(veiculoValido.isLigado);
        }


        [Fact]
        public void Acelerar_com_veiculo_desligado__deve_retornar_erro_veiculo_desligado()
        {
            Assert.Throws<VeiculoDesligadoException>(() => veiculoValido.Acelerar());
        }

        [Fact]
        public void Acelerar__deve_acrescentar_20_de_velocidade()
        {
            veiculoValido.Ligar();
            var velocidadeInicial = veiculoValido.velocidade;
            veiculoValido.Acelerar();
            var velocidadeFinal = veiculoValido.velocidade;

            Assert.Equal(expected: velocidadeInicial + 20, actual: velocidadeFinal);
        }

        [Fact]
        public void Abastecer_0_de_combustivel__deve_retornar_0_de_combustivel_atual()
        {
            veiculoValido.Abastecer(0);
            Assert.Equal(expected: 0, actual: veiculoValido.litrosCombustivel);
        }

        [Fact]
        public void Abastecer_40_de_combustivel__deve_retornar_40_de_combustivel_atual()
        {
            veiculoValido.Abastecer(40);
            Assert.Equal(expected: 40, actual: veiculoValido.litrosCombustivel);
        }

        [Fact]
        public void Abastecer_61_de_combustivel__deve_retornar_erro_combustivel_fora_do_limite()
        {
            Assert.Throws<CombustivelForaDoLimiteException>(() => veiculoValido.Abastecer(61));
        }

        [Fact]
        public void Frear_com_velocidade_20__deve_parar_o_veiculo()
        {
            veiculoValido.Ligar();
            veiculoValido.Acelerar();// +20 de velocidade
            veiculoValido.Frear();

            Assert.True(veiculoValido.isParado);
        }

        [Fact]
        public void Frear_com_velocidade_0__deve_retornar_erro_veiculo_parado()
        {
            veiculoValido.Ligar();
            Assert.Throws<VeiculoParadoException>(() => veiculoValido.Frear());
        }

        [Fact]
        public void Pintar_com_azul__deve_retornar_veiculo_pintado_de_azul()
        {
            var cor = "Azul";
            veiculoValido.Pintar(cor);

            Assert.Equal(expected: cor, actual: veiculoValido.cor);
        }

        [Fact]
        public void Pintar_com_cor_vazia__deve_retornar_erro_cor_invalida()
        {
            Assert.Throws<ArgumentException>(() => veiculoValido.Pintar(""));
        }

        [Fact]
        public void Desligar_um_veiculo_ligado__deve_desligar_o_veiculo()
        {
            veiculoValido.Ligar();
            veiculoValido.Desligar();

            Assert.True(veiculoValido.isDesligado);
        }

        [Fact]
        public void Desligar_um_veiculo_ja_desligado__nao_deve_ligar_o_veiculo()
        {
            veiculoValido.Desligar();
            veiculoValido.Desligar();

            Assert.True(veiculoValido.isDesligado);
        }

        [Fact]
        public void Desligar_um_veiculo_em_movimento__deve_retornar_erro_veiculo_em_movimento()
        {
            veiculoValido.Ligar();
            veiculoValido.Acelerar();

            Assert.Throws<VeiculoEmMovimentoException>(() => veiculoValido.Desligar());
        }
    }
}
using System;
using Exercicio1.util;

namespace Exercicio1
{
    public class Veiculo
    {
        #region Construtor e propriedades
        public Veiculo(string marca, string modelo, string placa,
         string cor, float km, double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.km = km;
            this.preco = preco;

            this.isLigado = false;
        }
        public string marca { get; private set; }
        public string modelo { get; private set; }
        public string placa { get; private set; }
        public string cor { get; private set; }
        public float km { get; private set; }
        public bool isLigado { get; private set; }
        public int litrosCombustivel { get; private set; }
        public int velocidade { get; private set; }
        public double preco { get; set; }

        #endregion

        #region Constantes
        public const int VELOCIDADE_POR_ACELERACAO = 20;
        public const int LIMITE_COMBUSTIVEL = 60;
        public const int VELOCIDADE_POR_DESACELERACAO = 20;
        #endregion

        public bool isParado => this.velocidade == 0;
        public bool isDesligado => !this.isLigado;

        public void Acelerar()
        {
            if (this.isDesligado) throw new VeiculoDesligadoException();

            this.velocidade += VELOCIDADE_POR_ACELERACAO;
            System.Console.WriteLine($"Acelerando com velocidade: {this.velocidade}");
        }

        public void Abastecer(int combustivel)
        {
            if (combustivel > LIMITE_COMBUSTIVEL)
            {
                throw new CombustivelForaDoLimiteException($"Esse veiculo possui {LIMITE_COMBUSTIVEL} de limite de combustivel!");
            }

            this.litrosCombustivel += combustivel;
        }


        public void Frear()
        {
            if (this.isDesligado) throw new VeiculoDesligadoException();

            if (isParado) throw new VeiculoParadoException();
            
            this.velocidade -= VELOCIDADE_POR_DESACELERACAO;
            if (this.velocidade < 0) this.velocidade = 0;

            System.Console.WriteLine($"Desacelerando com velocidade: {this.velocidade}");
        }

        public void Pintar(string cor)
        {
            if(string.IsNullOrEmpty(cor)) throw new ArgumentException("A cor não pode ser vazia!");
            this.cor = cor;
        }

        public void Ligar()
        {
            if (!this.isLigado) this.isLigado = true;
        }

        public void Desligar()
        {
            if (this.isLigado)
            {
                if (!isParado) throw new VeiculoEmMovimentoException("Não foi possível desligar, pois o veículo se encontra em movimento!");
                this.isLigado = false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Jokenpo.Util;

namespace Jokenpo.Entities
{
    public class Jogo
    {
        public Jogo(Jogador jogador1, Jogador jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }

        public Jogador Jogador1 { get; private set; }
        public Jogador Jogador2 { get; private set; }

        public Resultados Resultado { get; private set; }


        public void Duelar(params Partida[] partidas)
        {
            Duelar(partidas.ToList());
        }

        public void Duelar(List<Partida> partidas)
        {
            var vitoriasJogador1 = 0;
            var vitoriasJogador2 = 0;

            foreach (var partida in partidas)
            {
                var metadeDasPartidas = partidas.Count / 2;
                if (vitoriasJogador1 > metadeDasPartidas || vitoriasJogador2 > metadeDasPartidas) break;

                var vencedorDaPartida = partida.Resultado;

                if (vencedorDaPartida == Resultados.Jogador1) vitoriasJogador1++;
                else if (vencedorDaPartida == Resultados.Jogador2) vitoriasJogador2++;
            }

            if (vitoriasJogador1 > vitoriasJogador2) Resultado = Resultados.Jogador1;
            else if (vitoriasJogador2 > vitoriasJogador1) Resultado = Resultados.Jogador2;
            else Resultado = Resultados.Empate;
        }
    }
}
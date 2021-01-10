using System;
using Jokenpo.Util;

namespace Jokenpo.Entities
{
    public class Partida
    {
        public Partida(Opcoes jogador1, Opcoes jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;

            DecidirVencedor();
        }

        public Opcoes Jogador1 { get; private set; }
        public Opcoes Jogador2 { get; private set; }
        public Resultados Resultado { get; private set; }

        private void DecidirVencedor()
        {
            Func<Opcoes, ResultadosDuelo> DuelarContra;

            if (Jogador1 == Opcoes.Papel)
            {
                DuelarContra = adversario => DuelarPapelContra(adversario);
            }
            else if (Jogador1 == Opcoes.Tesoura)
            {
                DuelarContra = adversario => DuelarTesouraContra(adversario);
            }
            else
            {
                DuelarContra = adversario => DuelarPedraContra(adversario);
            }

            var resultadoDuelo = DuelarContra(Jogador2);

            if (resultadoDuelo == ResultadosDuelo.VITORIA) Resultado = Resultados.Jogador1;
            else if (resultadoDuelo == ResultadosDuelo.DERROTA) Resultado = Resultados.Jogador2;
            else Resultado = Resultados.Empate;
        }

        private ResultadosDuelo DuelarPapelContra(Opcoes adversario)
        {
            if (adversario == Opcoes.Pedra) return ResultadosDuelo.VITORIA;

            if (adversario == Opcoes.Tesoura) return ResultadosDuelo.DERROTA;

            return ResultadosDuelo.EMPATE;
        }

        private ResultadosDuelo DuelarPedraContra(Opcoes adversario)
        {
            if (adversario == Opcoes.Tesoura) return ResultadosDuelo.VITORIA;

            if (adversario == Opcoes.Papel) return ResultadosDuelo.DERROTA;

            return ResultadosDuelo.EMPATE;
        }

        private ResultadosDuelo DuelarTesouraContra(Opcoes adversario)
        {
            if (adversario == Opcoes.Papel) return ResultadosDuelo.VITORIA;

            if (adversario == Opcoes.Pedra) return ResultadosDuelo.DERROTA;

            return ResultadosDuelo.EMPATE;
        }

        enum ResultadosDuelo
        {
            VITORIA,
            DERROTA,
            EMPATE
        }
    }


}
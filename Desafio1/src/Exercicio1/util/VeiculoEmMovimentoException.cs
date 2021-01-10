using System;

namespace Exercicio1.util
{
    public class VeiculoEmMovimentoException : Exception
    {
        public VeiculoEmMovimentoException(string message = "O veículo se encontra em movimento!")
            : base(message)
        {
        }

        public VeiculoEmMovimentoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
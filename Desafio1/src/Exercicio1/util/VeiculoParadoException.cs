using System;

namespace Exercicio1.util
{
    public class VeiculoParadoException : Exception
    {
        public VeiculoParadoException(string message = "O veículo já se encontra parado")
            : base(message)
        {
        }

        public VeiculoParadoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
using System;

namespace Exercicio1.util
{
    public class VeiculoDesligadoException: Exception
    {
        public VeiculoDesligadoException(string message = "O veículo está desligado!")
            : base(message)
        {
        }

        public VeiculoDesligadoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
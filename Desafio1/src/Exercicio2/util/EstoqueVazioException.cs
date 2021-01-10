using System;

namespace Exercicio2.util
{
    public class EstoqueVazioException : Exception
    {
        public EstoqueVazioException(string message)
            : base(message)
        {
        }

        public EstoqueVazioException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
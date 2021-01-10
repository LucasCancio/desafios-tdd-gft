using System;

namespace Exercicio1.util
{
    public class CombustivelForaDoLimiteException : Exception
    {
        public CombustivelForaDoLimiteException()
        {
        }

        public CombustivelForaDoLimiteException(string message)
            : base(message)
        {
        }

        public CombustivelForaDoLimiteException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
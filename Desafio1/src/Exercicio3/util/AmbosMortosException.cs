using System;

namespace Exercicio3.util
{
    public class AmbosMortosException : Exception
    {
        public AmbosMortosException(string message="Ambos os personagens, estão mortos!")
            : base(message)
        {
        }

        public AmbosMortosException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
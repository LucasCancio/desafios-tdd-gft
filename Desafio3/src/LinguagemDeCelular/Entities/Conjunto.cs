using System.Collections.Generic;

namespace LinguagemDeCelular.Entities
{
    public class Conjunto
    {
        public Conjunto(List<char> letras, int numeroCorrespondente)
        {
            Letras = letras;
            Numero = numeroCorrespondente;
        }

        public List<char> Letras { get; private set; }
        public int Numero { get; private set; }
    }
}
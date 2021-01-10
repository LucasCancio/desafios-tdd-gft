using System;
using System.Collections.Generic;
using System.Linq;
using Jokenpo.Util;

namespace Jokenpo.Entities
{
    public class Jogador
    {
        public Jogador(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }


        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType()) return false;

            var jogador = (Jogador)obj;
            return this.Nome.Equals(jogador.Nome, StringComparison.InvariantCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
}
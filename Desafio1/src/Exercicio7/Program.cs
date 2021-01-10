using System;
using Exercicio7.model;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerente = new Gerente("Claudio", 32, 3000);
            var supervisor = new Supervisor("Claudia", 41, 4000);
            var vendedor = new Vendedor("Claudinho", 24, 2000);

            gerente.Imprimir();
            supervisor.Imprimir();
            vendedor.Imprimir();
        }
    }
}

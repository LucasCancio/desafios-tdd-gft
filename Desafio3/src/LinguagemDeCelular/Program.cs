using System;
using LinguagemDeCelular.Entities;

namespace LinguagemDeCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Escrevendo no Celular --");

            Console.WriteLine("Digite uma palavra:");

            var palavra = Console.ReadLine();
            Mensagem mensagem = null;
            try
            {
                mensagem = new Mensagem(palavra);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Digite outra palavra:");
                palavra = Console.ReadLine();
            }

            Console.WriteLine($"Mensagem: {mensagem.Texto}");
            Console.WriteLine($"Mensagem em SMS: {mensagem.Sms}");
        }
    }
}

using System;
using System.Collections.Generic;
using Exercicio3.model;
using Exercicio3.util;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var mago1 = new Mago("Patolino", 500, 300, 2, 3, 50, 600, new List<string>() { "Congelar", "Soltar fogo" });
                var mago2 = new Mago("Gandalf", 500, 100, 2, 200, 10, 600, new List<string>() { "Não deixar passar", "Cajadada" });

                var guerreiro = new Guerreiro("Guerreirão", 1000, 2, 1, 0, 200, 7, new List<string>() { "Tascar o espadão" });
                System.Console.WriteLine($"Há {Guerreiro.qtde} guerreiro(s) e {Mago.qtde} mago(s)");

                mago1.AprenderMagia("Parar o tempo");
                guerreiro.AprenderHabilidade("Aumento de vigor");

                System.Console.WriteLine($"\nHabilidades do mago {mago1.nome}:");
                mago1.ListarMagias();

                System.Console.WriteLine($"\nHabilidades do guerreiro {guerreiro.nome}:");
                guerreiro.ListarHabilidades();

                TestarAumentoDeLevel(mago1);
                TestarAumentoDeLevel(guerreiro);

                Batalhar(mago1, mago2);
                Batalhar(mago1, guerreiro);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public static void TestarAumentoDeLevel(Personagem personagem)
        {
            System.Console.WriteLine($"\n-- {personagem.GetType().Name} {personagem.nome}--");

            System.Console.WriteLine("\n- Antes de subir de level:");
            personagem.ImprimirCaracteristicas();

            personagem.LvlUp();

            System.Console.WriteLine("- Depois de subir de level:");
            personagem.ImprimirCaracteristicas();
        }

        public static Personagem Batalhar(Personagem lutador1, Personagem lutador2)
        {
            lutador1.TomarPocaoDeVida();
            lutador2.TomarPocaoDeVida();
            
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine($"\nSenhoras e Senhores, hoje teremos a batalha entre: ");
            System.Console.WriteLine($"{lutador1.nome} ({lutador1.vida}Hp) x {lutador2.nome} ({lutador2.vida}Hp)!!!");


            System.Console.WriteLine("LUTEM!\n");
            while (lutador1.estaVivo && lutador2.estaVivo)
            {
                Random rand = new Random();
                int vez = rand.Next(0, 2);
                if (vez == 1)
                {
                    AcertarAtaque(lutadorQueAtaca: lutador1, LutadorQueRecebe: lutador2);
                }
                else
                {
                    AcertarAtaque(lutadorQueAtaca: lutador2, LutadorQueRecebe: lutador1);
                }
            }
            if (!lutador1.estaVivo && !lutador2.estaVivo) throw new AmbosMortosException();

            Personagem vencedor = lutador1.estaVivo ? lutador1 : lutador2;
            System.Console.WriteLine($"Temos um vencedor!! \t {vencedor.nome}");

            return vencedor;
        }

        public static void AcertarAtaque(Personagem lutadorQueAtaca, Personagem LutadorQueRecebe)
        {
            int valorAtaque = lutadorQueAtaca.Attack();
            LutadorQueRecebe.ReceberAtaque(valorAtaque);

            System.Console.WriteLine($"-> {lutadorQueAtaca.nome} acerta {valorAtaque} de dano, em {LutadorQueRecebe.nome}");
        }
    }
}

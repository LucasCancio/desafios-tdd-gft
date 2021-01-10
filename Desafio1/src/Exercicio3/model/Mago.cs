using System;
using System.Collections.Generic;

namespace Exercicio3.model
{
    public class Mago : Personagem
    {
        public static int qtde { get; private set; }
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level, List<string> magias) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            this.magias = magias;
            Mago.qtde++;
        }

        public List<string> magias { get; private set; }

        public override void LvlUp()
        {
            base.LvlUp();

            this.mana++;
            this.inteligencia++;
        }

        public override int Attack()
        {
            return new Random().Next(MIN_ATTACK, MAX_ATTACK) + this.level * this.inteligencia;
        }
        public void AprenderMagia(string magia)
        {
            if(string.IsNullOrEmpty(magia)) throw new ArgumentException("A Magia não pode ser vazia!");

            this.magias.Add(magia);
        }

        public void ListarMagias()
        {
            this.magias.ForEach(magia => System.Console.WriteLine($"* {magia}"));
        }

        public Mago Clone()
        {
            return (Mago)this.MemberwiseClone();
        }
    }
}
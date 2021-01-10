using System;
using System.Collections.Generic;

namespace Exercicio3.model
{
    public class Guerreiro : Personagem
    {
        public static int qtde { get; private set; }
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level, List<string> habilidades) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            this.habilidades = habilidades;
            Guerreiro.qtde++;
        }

        public List<string> habilidades { get; private set; }

        public override void LvlUp()
        {
            base.LvlUp();

            this.vida++;
            this.forca++;
        }

        public override int Attack()
        {
            return new Random().Next(MIN_ATTACK, MAX_ATTACK) + this.level * this.forca;
        }

        public void AprenderHabilidade(string habilidade)
        {
            if(string.IsNullOrEmpty(habilidade)) throw new ArgumentException("A Habilidade não pode ser vazia!");

            this.habilidades.Add(habilidade);
        }

        public void ListarHabilidades()
        {
            this.habilidades.ForEach(habilidade => System.Console.WriteLine($"* {habilidade}"));
        }

        public Guerreiro Clone()
        {
            return (Guerreiro)this.MemberwiseClone();
        }
    }
}
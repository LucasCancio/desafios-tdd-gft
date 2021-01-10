using System;

namespace Exercicio3.model
{
    public abstract class Personagem
    {
        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            this.nome = nome;
            this.vida = vida;
            this.mana = mana;
            this.xp = xp;
            this.inteligencia = inteligencia;
            this.forca = forca;
            this.level = level;

            this.maxVida = vida;
        }
        public string nome { get; protected set; }
        public int vida { get; protected set; }
        public int mana { get; protected set; }
        public float xp { get; protected set; }
        public int inteligencia { get; protected set; }
        public int forca { get; protected set; }
        public int level { get; protected set; }
        public bool estaVivo { get { return this.vida != 0; } }
        public int maxVida { get; protected set; }

        public virtual void LvlUp()
        {
            this.vida++;
            this.mana++;
            this.inteligencia++;
            this.forca++;

            this.level++;
        }

        public const int MIN_ATTACK = 0;
        public const int MAX_ATTACK = 300;
        public virtual int Attack()
        {
            return new Random().Next(MIN_ATTACK, MAX_ATTACK);
        }

        public void ReceberAtaque(int valorAtaque)
        {
            if (valorAtaque < 0) throw new ArgumentException("O ataque não pode ser negativo!");

            if (this.vida == 0)
            {
                System.Console.WriteLine($"O personagem {this.nome} já esta morto!");
                return;
            }

            this.vida -= valorAtaque;
            if (this.vida < 0) this.vida = 0;
        }

        public void TomarPocaoDeVida()
        {
            this.vida = this.maxVida;
        }
        public void ImprimirCaracteristicas()
        {
            System.Console.WriteLine($"Level {this.level}\nVida: {this.vida}, Mana: {this.mana}, Inteligencia: {this.inteligencia}, Força: {this.forca}");
        }
    }
}
using System.Collections.Generic;
using Bogus;
using Exercicio3.model;

namespace Exercicio3.Tests.Builders
{
    public class MagoBuilder
    {
        private string _nome;
        private int _vida;
        private int _mana;
        private float _xp;
        private int _inteligencia;
        private int _forca;
        private int _level;


        private List<string> _magias;

        public static MagoBuilder Novo()
        {
            return new MagoBuilder();
        }

        public MagoBuilder()
        {
            var faker = new Faker();
            _nome = faker.Name.FullName();
            _vida = faker.Random.Int(1, 1_000);
            _mana = faker.Random.Int(1, 10_000);
            _xp = faker.Random.Int(1, 10_000);
            _inteligencia = faker.Random.Int(1, 10_000);
            _forca = faker.Random.Int(1, 1_000);
            _level = faker.Random.Int(1, 10_000);

            _magias = new List<string>();
        }

        public MagoBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public MagoBuilder ComVida(int vida)
        {
            _vida = vida;
            return this;
        }

        public MagoBuilder ComMana(int mana)
        {
            _mana = mana;
            return this;
        }

        public MagoBuilder ComXp(float xp)
        {
            _xp = xp;
            return this;
        }

        public MagoBuilder ComInteligencia(int inteligencia)
        {
            _inteligencia = inteligencia;
            return this;
        }

        public MagoBuilder ComForca(int forca)
        {
            _forca = forca;
            return this;
        }

        public MagoBuilder ComLevel(int level)
        {
            _level = level;
            return this;
        }

        public MagoBuilder ComMagias(List<string> magias)
        {
            _magias = magias;
            return this;
        }

        public Mago Construir()
        {
            return new Mago(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level, _magias);
        }
    }
}
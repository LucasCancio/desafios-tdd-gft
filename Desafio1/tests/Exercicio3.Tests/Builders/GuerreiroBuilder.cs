using System.Collections.Generic;
using Bogus;
using Exercicio3.model;

namespace Exercicio3.Tests.Builders
{
    public class GuerreiroBuilder
    {
        private string _nome;
        private int _vida;
        private int _mana;
        private float _xp;
        private int _inteligencia;
        private int _forca;
        private int _level;


        private List<string> _habilidades;

        public static GuerreiroBuilder Novo()
        {
            return new GuerreiroBuilder();
        }

        public GuerreiroBuilder()
        {
            var faker = new Faker();
            _nome = faker.Name.FullName();
            _vida = faker.Random.Int(1, 10_000);
            _mana = faker.Random.Int(1, 1_000);
            _xp = faker.Random.Int(1, 10_000);
            _inteligencia = faker.Random.Int(1, 1_000);
            _forca = faker.Random.Int(1, 10_000);
            _level = faker.Random.Int(1, 10_000);

            _habilidades = new List<string>();
        }

        public GuerreiroBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public GuerreiroBuilder ComVida(int vida)
        {
            _vida = vida;
            return this;
        }

        public GuerreiroBuilder ComMana(int mana)
        {
            _mana = mana;
            return this;
        }

        public GuerreiroBuilder ComXp(float xp)
        {
            _xp = xp;
            return this;
        }

        public GuerreiroBuilder ComInteligencia(int inteligencia)
        {
            _inteligencia = inteligencia;
            return this;
        }

        public GuerreiroBuilder ComForca(int forca)
        {
            _forca = forca;
            return this;
        }

        public GuerreiroBuilder ComLevel(int level)
        {
            _level = level;
            return this;
        }

        public GuerreiroBuilder ComHabilidades(List<string> habilidades)
        {
            _habilidades = habilidades;
            return this;
        }

        public Guerreiro Construir()
        {
            return new Guerreiro(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level, _habilidades);
        }
    }
}
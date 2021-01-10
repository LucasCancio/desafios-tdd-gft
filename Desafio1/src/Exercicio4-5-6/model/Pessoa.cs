namespace Exercicio4.model
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            this.nome=nome;
            this.idade=idade;
        }
        public string nome { get; private set; }
        public int idade { get; private set; }
    }
}
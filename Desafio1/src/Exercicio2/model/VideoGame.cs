namespace Exercicio2.model
{
    public class VideoGame : Produto
    {
        public VideoGame(string nome, double preco, int qtd) : base(nome, preco, qtd)
        { }
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }
        public string marca { get; set; }
        public string modelo { get; set; }
        public bool isUsado { get; set; }

        private const double IMPOSTO_VIDEOGAME = 0.45;
        private const double IMPOSTO_VIDEOGAME_USADO = 0.25;

        public override string ToString()
        {
            return $"Video-game: {this.modelo}, preço: {this.preco}, quantidade: {this.qtd} em estoque.";
        }

        public override double CalculaImposto()
        {
            if (this.isUsado) return this.preco * IMPOSTO_VIDEOGAME_USADO;
            return this.preco * IMPOSTO_VIDEOGAME;
        }

        public void ImprimirImposto()
        {
            System.Console.WriteLine($"Imposto {this.nome} {this.modelo} {(this.isUsado ? "usado" : "")} R${this.CalculaImposto()}");
        }
    }
}
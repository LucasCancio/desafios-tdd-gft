namespace Exercicio2.model
{
    public class Livro : Produto
    {
        public Livro(string nome, double preco, int qtd) : base(nome, preco, qtd)
        { }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }
        public string autor { get; set; }
        public string tema { get; set; }
        public int qtdPag { get; set; }


        private const double IMPOSTO_LIVRO = 0.10;
        private const double IMPOSTO_LIVRO_EDUCATIVO = 0;


        public override string ToString()
        {
            return $"Titulo: {this.nome}, preço: {this.preco}, quantidade: {this.qtd} em estoque.";
        }

        public override double CalculaImposto()
        {
            if (this.tema.ToLower() == "educativo")
                return this.preco * IMPOSTO_LIVRO_EDUCATIVO;
            return this.preco * IMPOSTO_LIVRO;
        }

        public void ImprimirImposto(){
            if (this.tema.ToLower() == "educativo")
            {
                System.Console.WriteLine($"Livro educativo não tem imposto: {this.nome}");  
            }
            else
            {
                System.Console.WriteLine($"R${this.CalculaImposto()} de impostos sobre o livro {this.nome}");
            }
        }
    }
}
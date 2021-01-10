using Exercicio2.interfaces;

namespace Exercicio2.model
{
    public abstract class Produto : Imposto
    {
        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }
        public string nome { get; set; }
        public double preco { get; set; }
        public int qtd { get; set; }

        public double precoComImposto { get{
            return this.preco + CalculaImposto();
        } }
        
        public virtual double CalculaImposto()
        {
            throw new System.NotImplementedException();
        }
    }
}
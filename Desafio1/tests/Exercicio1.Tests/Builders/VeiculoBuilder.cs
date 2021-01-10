using Bogus;

namespace Exercicio1.Builders
{
    public class VeiculoBuilder
    {
        private string _marca;
        private string _modelo;
        private string _placa;
        private string _cor;
        private float _km;
        private double _preco;
        public static VeiculoBuilder Novo()
        {
            return new VeiculoBuilder();
        }

        private string[] cores = { "Azul", "Vermelho", "Verde", "Amarelo", "Roxo", "Laranja", "Preto", "Branco" };
        public VeiculoBuilder()
        {
            var faker = new Faker();
            _marca = faker.Company.CompanyName();
            _modelo = faker.Random.Word();
            _placa = faker.Random.Word();
            var colorIndex = faker.Random.Int(0, cores.Length - 1);
            _cor = cores[colorIndex];
            _km = faker.Random.Float(0, 1_000);
            _preco = faker.Random.Double(0, 1_000_000);
        }

        public VeiculoBuilder ComMarca(string marca)
        {
            _marca = marca;
            return this;
        }

        public VeiculoBuilder ComModelo(string modelo)
        {
            _modelo = modelo;
            return this;
        }

        public VeiculoBuilder ComPlaca(string placa)
        {
            _placa = placa;
            return this;
        }

        public VeiculoBuilder ComCor(string cor)
        {
            _cor = cor;
            return this;
        }

        public VeiculoBuilder ComKm(float km)
        {
            _km = km;
            return this;
        }
    
        public VeiculoBuilder ComPreco(double preco)
        {
            _preco = preco;
            return this;
        }
        

        public Veiculo Construir()
        {
            return new Veiculo(_marca, _modelo, _placa, _cor, _km, _preco);
        }
    }
}
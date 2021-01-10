using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var veiculoTeste = new Veiculo("Marca teste", "Modelo teste", "Placa teste", "Preto", 0, 10000);

                veiculoTeste.Ligar();
                System.Console.WriteLine("Veiculo ligado com sucesso");

                veiculoTeste.Acelerar();
                veiculoTeste.Acelerar();
                veiculoTeste.Acelerar();
                veiculoTeste.Acelerar();
                veiculoTeste.Acelerar();

                GerarCombustivelForaDoLimite(veiculoTeste);
                GerarVeiculoEmMovimento(veiculoTeste);

                while (!veiculoTeste.isParado)
                {
                    veiculoTeste.Frear();
                }

                veiculoTeste.Desligar();
                System.Console.WriteLine("Veiculo desligado com sucesso");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        private static void GerarCombustivelForaDoLimite(Veiculo veiculo)
        {
            try
            {
                veiculo.Abastecer(Veiculo.LIMITE_COMBUSTIVEL + 1);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        private static void GerarVeiculoEmMovimento(Veiculo veiculo)
        {
            try
            {
                veiculo.Acelerar();
                veiculo.Desligar();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}

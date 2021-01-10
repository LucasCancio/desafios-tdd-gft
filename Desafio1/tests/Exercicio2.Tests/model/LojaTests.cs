using System.Collections.Generic;
using Exercicio2.model;
using Exercicio2.Tests.Builders;
using Exercicio2.util;
using Xunit;

namespace Exercicio2.Tests.model
{
    public class LojaTests
    {
        /* [Fact]
        public void ListaLivros__deve_listar_todos_os_livros_da_loja()
        {} */

        [Fact]
        public void ListaLivros__deve_retornar_erro_estoque_vazio__quando_nao_houver_livros_no_estoque()
        {
            Loja loja = LojaBuilder.Novo().Construir();
            Assert.Throws<EstoqueVazioException>(() => loja.ListaLivros());
        }

        /* [Fact]
        public void ListaVideoGames__deve_listar_todos_os_videogames_da_loja()
        {} */
        
        [Fact]
        public void ListaVideoGames__deve_retornar_erro_estoque_vazio__quando_nao_houver_videogames_no_estoque()
        {
            Loja loja = LojaBuilder.Novo().Construir();
            Assert.Throws<EstoqueVazioException>(() => loja.ListaVideoGames());
        }

        [Fact]
        public void CalculaPatrimonio__deve_retornar_o_preco_total_com_imposto_de_todos_os_produtos()
        {
            var livros = new List<Livro>()
            {
                LivroBuilder
                            .Novo()
                            .ComPreco(10)
                            .ComQtd(1)
                            .ComTema("Educativo")
                            .ConstruirCompleto(), // (10 + 0) * 1 = 10
                
                LivroBuilder
                            .Novo()
                            .ComPreco(20)
                            .ComQtd(2)
                            .ComTema("Aventura")
                            .ConstruirCompleto(), // 20 * 2 = 40
            };// Patrimonio -> 10 + 40 => 50

            var videoGames = new List<VideoGame>()
            {
                VideoGameBuilder
                            .Novo()
                            .ComPreco(100)
                            .ComQtd(2)
                            .Usado(false)
                            .ConstruirCompleto(), // 100 * 2 = 200

                VideoGameBuilder
                            .Novo()
                            .ComPreco(50)
                            .ComQtd(4)
                            .Usado(true)
                            .ConstruirCompleto(), // 50 * 4 = 200
            }; // Patrimonio -> 200 + 200 => 400


            Loja loja = LojaBuilder
                                .Novo()
                                .ComLivros(livros)
                                .ComVideoGames(videoGames)
                                .Construir(); // Patrimonio Total -> 50 + 400 => 450

            var patrimonio = loja.CalculaPatrimonio();

            Assert.Equal(expected: 450, actual: patrimonio);
        }
    }
}
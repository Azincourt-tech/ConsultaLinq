using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // FONTE DE DADOS
            var listaProdutos = new List<Produto>()
            {
                new Produto {Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 10},
                new Produto {Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1},
                new Produto {Id = 4, CategoriaId = 1, Nome = "Maquina de lavar", Status = false, Valor = 32},
                new Produto {Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 99},
                new Produto {Id = 6, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55},
                new Produto {Id = 8, CategoriaId = 1, Nome = "TV", Status = true, Valor = 45},
                new Produto {Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto {Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 90},
                new Produto {Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 12},
            };

            var listaCategorias = new List<Categoria>()
            {
                new Categoria {Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria {Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria {Id = 3, Status = true, Nome = "Vestuario"}
            };


            var resultado = from produto in listaProdutos
                            select new ProdutoDto 
                            { Nome = produto.Nome, 
                              Valor = produto.Valor, 
                              Status = produto.Status };




            foreach (var produto in resultado)
            {
                Console.WriteLine($" | {produto.Nome} | {produto.Valor} | {produto.Status}");
                
            }

            Console.ReadLine();

        }



        class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public bool Status { get; set; }
            public decimal Valor { get; set; }
            public int CategoriaId { get; set; }
            public List<Categoria> Categorias { get; set; }
        }

        class Categoria
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public bool Status { get; set; }
        }

        class ProdutoDto
        {
            public string Nome { get; set; }
            public decimal Valor { get; set; }
            public bool Status { get; set; }
        }




        #region Criando consulta com where e orderby

        //CRIAR UMA CONSULTA LINQ
        // 01 - consulta com where
        //var resultado = from produto in listaProdutos
        //                where produto.Nome.Substring(0,1) == "M" && produto.Status == true
        //                select produto;


        // 02- consulta com orderby
        //var resultado = from produto in listaProdutos
        //                where produto.Id > 1 && produto.Id < 6
        //                orderby produto.Id 
        //                select produto;

        #endregion
    }
}

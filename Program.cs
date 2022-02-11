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
                new Produto {Id = 4, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto {Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 90},
                new Produto {Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 12},
            };

            var listaCategorias = new List<Categoria>()
            {
                new Categoria {Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria {Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria {Id = 3, Status = true, Nome = "Vestuario"}
            };

            


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



        #region Criando consulta com where, orderby, groupby, join

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


        //03- consulta com groupby
        //var result = from prod in listaProdutos
        //             group prod by prod.CategoriaId into produtosgr
        //             select produtosgr;


        //04- consulta com Join
        //var result = from prod in listaProdutos
        //             join cat in listaCategorias
        //             on prod.CategoriaId equals cat.Id
        //             select new
        //             {
        //                 Produto = prod,
        //                 Categoria = cat
        //             };

        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Produto: {item.Produto.Nome} | Categoria: {item.Categoria.Nome}");
        //}



        #endregion



        #region Sintaxe do first, last e single

        //First
        //var result = listaProdutos.FirstOrDefault();

        //Console.WriteLine(result.Nome);

        //Last
        //var result = listaProdutos.LastOrDefault();

        //Console.WriteLine(result.Nome);

        //Single
        //var result = listaProdutos.SingleOrDefault(x => x.Id == 4);

        //Console.WriteLine(result.Nome);

        #endregion


        #region Projeção de dados

        //CONSULTA

        //var resultado = from produto in listaProdutos
        //                select new ProdutoDto 
        //                { Nome = produto.Nome, 
        //                  Valor = produto.Valor, 
        //                  Status = produto.Status };

        //foreach (var produto in resultado)
        //{
        //    Console.WriteLine($" | {produto.Nome} | {produto.Valor} | {produto.Status}");

        //}


        //CLASSE
        //class ProdutoDto
        //{
        //    public string Nome { get; set; }
        //    public decimal Valor { get; set; }
        //    public bool Status { get; set; }
        //}



        #endregion
    }
}

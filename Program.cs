using System;
using System.Collections;
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
            var listaProdutos = new List<Produto>() {

                new Produto
                {
                    Id = 9,
                    CategoriaId = 2,
                    Nome = "Geladeira",
                    Status = true,
                    Valor = 10,
                    Categorias = new List<Categoria>()
                    {
                        new Categoria()
                        {
                            Id = 1, Nome = "Categoria 01", Status = true
                        },
                        new Categoria()
                        {
                            Id = 2, Nome = "Categoria 02", Status = true
                        }
                    }


                },

                new Produto
                {
                    Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1,
                    Categorias = new List<Categoria>()
                    {
                        new Categoria()
                        {
                            Id = 3, Nome = "Categoria 03", Status = true
                        },
                        new Categoria()
                        {
                            Id = 4, Nome = "Categoria 04", Status = true
                        }
                    }
                },

            };



            Console.ReadLine();

        }

        class ProdutoResponse
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public decimal Valor { get; set; }

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


        #region Sintaxe do where, orderby, revert

        //where
        //var resultado = listaProdutos.Where(prod => prod.Id >= 2 && prod.Id <= 5);
        //var resultado = listaProdutos.Where(prod => FiltraProdutoPorValor(prod));

        //orderby e orderbydescinding
        //resultado = resultado.OrderBy(prod => prod.Id);

        //revert
        //resultado = resultado.Reverse();

        //foreach (var result in resultado)
        //{
        //    Console.WriteLine($"ID: {result.Id} | Nome: {result.Nome}");
        //}

        //classe utilizado no where

        //static bool FiltraProdutoPorValor(Produto produto)
        //{
        //    return produto.Valor > 50;
        //}

        #endregion


        #region Select


        //Select
        //primeira forma de fazer o select

        //var listaResposta = new List<ProdutoResponse>();


        //    foreach(var produto in listaProdutos)
        //    {
        //        listaResposta.Add(new ProdutoResponse()
        //{
        //    Id = produto.Id,
        //            Nome = produto.Nome,
        //            Valor = produto.Valor
        //        });

        //    }

        //    foreach(var p in listaResposta)
        //    {
        //        Console.WriteLine($"ID :{p.Id} | NOME: {p.Nome} | VALOR: {p.Valor}");
        //    }


        //forma simplificada do select

        //var response = listaProdutos.Select(prod => new ProdutoResponse() {
        //    Id = prod.Id,
        //    Nome = prod.Nome,
        //    Valor = prod.Valor,
        //});

        //response = response.OrderBy(prod => prod.Id);

        //foreach(var p in response)
        //{
        //    Console.WriteLine($"ID :{p.Id} | NOME: {p.Nome} | VALOR: {p.Valor}");
        //}


        #endregion


        #region SelectMany

        //SelectMany

        //var listaCategoria = listaProdutos.SelectMany(prod => prod.Categorias);


        //foreach(var categoria in listaCategoria)
        //{
        //    Console.WriteLine($"ID: {categoria.Id} | NOME: {categoria.Nome} | STATUS: {categoria.Status}");
        //}


        //Outro exemplo de selectmany
        //buscando apenas uma lista de string

        //var listaCategoria = listaProdutos.SelectMany(prod => new List<string>(
        //        prod.Categorias.Select(cat => cat.Nome)));

        ///SelectMany

        //    foreach (var nome in listaCategoria)
        //    {
        //        Console.WriteLine($"NOME: {nome} |");
        //    }

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

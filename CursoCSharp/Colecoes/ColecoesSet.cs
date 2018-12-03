using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("GOT", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Tem. de GOT", 99.9),
                new Produto("Poster", 9.9),
                livro
            };

            carrinho.UnionWith(combo);

            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3);

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);


            foreach (var item in carrinho)
            {
             //   Console.Write(carrinho.IndexOf(item)); //mostra o indice do elemento
                Console.WriteLine($" {item.Nome}, {item.Preco}");
            }

            //Console.WriteLine( carrinho.LastIndexOf(livro) );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    //não precisa ser public
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto;

        //construtor
        public Produto(string Nome, double Preco, double desconto)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            Desconto = desconto;
        }

        //construtor padrão
        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }

    }
    class AtributosEstaticos
    {

        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 1.50,
                //Desconto = 0
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.05;
            Console.WriteLine("Preço com desconto {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto {0}", produto2.CalcularDesconto());
        }
    }
}

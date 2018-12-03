using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("Nome " + nome + " Marca " + marca + " Preço " + preco);
            Console.WriteLine("Nome {0}, Marca {1}, Preço {2}.",nome, marca, preco);
            Console.WriteLine($"O {nome} da {marca} é bom!");
            Console.WriteLine($"Cálculo: 1+2 = {1+2}");
        }
    }
}

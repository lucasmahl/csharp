using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //preco desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;

            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O reço final é R${0}", totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double IMC = peso / Math.Pow(altura,2);//altura ao quadrado

            Console.WriteLine("IMC: {0}.", IMC.ToString("#.##"));

            //número par/impar
            int par = 2;
            int impar = 3;

            Console.WriteLine($"{par}/2 tem resto {par % 2}");
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}

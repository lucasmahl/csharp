using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//mostra apenas uma casa decimal

            Console.WriteLine(valor.ToString("C"));//moeda
            Console.WriteLine(valor.ToString("P"));//percentual
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0",cultura));//sem nenhuma casa decimal

            int inteiro = 123;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}

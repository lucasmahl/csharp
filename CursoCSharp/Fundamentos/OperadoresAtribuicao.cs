using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;

            num1 += 10;//num1 = num1 + 10;
            num1 -= 3;//num1 = num1 - 3;
            num1 *= 5;//num1 = num1 * 5;
            num1 /= 2;//num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            var valor = 1000125.25;
            Console.WriteLine(valor);
            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.Write(valor.ToString("C2", cultura));
 
        }
    }
}

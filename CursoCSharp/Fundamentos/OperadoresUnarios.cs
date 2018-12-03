using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);//inverte o valor negativo do "valorNegativo" para positivo
            Console.WriteLine(!booleano);
            numero1++;
            Console.WriteLine(numero1);
            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);//diminui o número2, depois compara, e depois acrescenta +1 no numero1
            Console.WriteLine("{0} e {1} ",numero1,numero2);
        }
    }
}

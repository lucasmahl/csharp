using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            //igual a de cima
            int? num2 = null;

            //não é valido
            //int num3 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num1 = {0}", num1);
            }
            else
            {
                Console.WriteLine("Não possui valor!");
            }

            //setado o valor padrão para 1000
            int valor = num1 ?? 1000;//se num1 for nulo, será mudado para 1000
            Console.WriteLine(valor);

            bool? booleano = null;
            bool resultado = booleano.GetValueOrDefault();

            Console.WriteLine(resultado);

            try
            {
                //dará errado, pois o valor está nulo
                //int x = num1.Value;
                //int y = num2.Value;
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();

                Console.WriteLine(x+y);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

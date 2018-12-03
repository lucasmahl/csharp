using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica{
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //não estático, so acessível a partir da instancia,
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado {0}",resultado);

            //para o metódo não estático
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,3));
            
        }
    }
}

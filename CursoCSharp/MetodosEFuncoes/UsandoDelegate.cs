using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImprimirSoma(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2,3));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5,8);

            //o ultimo double abaixo é o tipo de retorno
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 5.25));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.3,3.6);
        }
    }
}

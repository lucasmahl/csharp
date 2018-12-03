using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNum)
        {
            return num + outroNum;
        }

        public static int subtracao(this int num, int outroNum)
        {
            return num - outroNum;
        }
    }
    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int num = 5;

            Console.WriteLine(num = num.Soma(3));
            Console.WriteLine(num);
            Console.WriteLine(num.subtracao(2));
            Console.WriteLine(num);
            Console.WriteLine(3.Soma(7));
        }
    }
}

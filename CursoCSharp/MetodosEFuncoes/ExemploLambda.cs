using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {

        public static void Executar()
        {
            //action não é obrigado a ter retorno
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com c#!");
            };

            algoNoConsole();

            //o int abaixo é o tipo de retorno
            Func<int> jogarDado = () =>
            {
                Random rand = new Random();
            //func é obrigado a retornar
                return rand.Next(1, 7);//randomico de 1 a 6
            };
            Console.WriteLine(jogarDado());

            //func pode receber qntos parametros vc quiser, não só int e string
            Func<int, string> conversorHexa = numero => numero.ToString("X");

            Console.WriteLine(conversorHexa(4321));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            //como não há corpo, implicitamento há um return
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(30,11,2018));
        }

    }
}

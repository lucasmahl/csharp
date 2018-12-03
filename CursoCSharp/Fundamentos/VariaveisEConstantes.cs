using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.1415;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            bool estaChovento = true; 
            Console.WriteLine("Está chovendo? " + estaChovento);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldoDeGols " + saldoDeGols);

        }
    }
}

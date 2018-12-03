using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class IfElseIf
    {
        public static void Executar()
        {
            Console.Write("Nota: ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra");
            }else if (nota >= 7.0 && nota < 9)
            {
                Console.WriteLine("Aprovado!");
            }else if (nota >= 5 && nota < 7)
            {
                Console.WriteLine("Recuperação!");
            }
            else
            {
                Console.WriteLine("Te vejo na próxima...");
            }

            Console.WriteLine($"Nota: {nota}!");
            Console.WriteLine("Fim!");
        }
    }
}

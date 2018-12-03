using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);
            //double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Possui bom comportamento?(S/N) ");
            entrada = Console.ReadLine();

            if (entrada == "S" || entrada =="s")
            {
                bomComportamento = true;
                Console.WriteLine(bomComportamento);
                Console.WriteLine(nota);
            }

            if (nota == 10.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
                Console.WriteLine(bomComportamento);
                Console.WriteLine(nota);

            }
            
        }
    }
}

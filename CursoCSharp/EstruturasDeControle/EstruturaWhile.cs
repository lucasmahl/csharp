using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 6);//de 1 a 5

            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;//armazena a cor anterior do background
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número {0} encontrado, em {1} tentativas!",numeroSecreto, tentativas);
                    Console.BackgroundColor = corAnterior;
                }else if (palpite>numeroSecreto)
                {
                    Console.WriteLine("Número menor, tente novamente...");
                    Console.WriteLine("{0} tentativas restantes.", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Número maior, tente novamente...");
                    Console.WriteLine("{0} tentativas restantes.", tentativasRestantes);
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "Teste";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);

            }

            var alunos = new string[] { "Ana", "Lucas", "Fran", "Ju" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}

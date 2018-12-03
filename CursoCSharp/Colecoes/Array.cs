using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            //dentro do array só poderá ter tipos strings, por causa do tipo
            String[] alunos = new string[5];

            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Dani";
            alunos[4] = "Elias";
           // alunos[5] = "José";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = {9, 5, 6.5, 7, 3.5 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine("\n" + media);

            Char[] letras = {'A','B','D','G'};
            string palavra = new string(letras);
            Console.WriteLine(palavra);

            for (int i = 0; i < palavra.Length; i++)
            {
                Console.WriteLine(palavra[i]);
            }
        }
    }
}

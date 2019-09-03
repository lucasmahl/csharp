using System;
using System.Collections.Generic;

using System.Linq;
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

            string[] lista = new string[4];
            lista[0] = "Lucas";
            lista[1] = "Carlos";
            lista[2] = "Bia";
            lista[3] = "Abrão";

            Console.WriteLine("LISTA EM ORDEM ALFABÉTICA");

            //array em ordem alfabetica
            var selecao =
                from s in lista
                orderby s
                select s;

            foreach (var s in selecao) {
                Console.WriteLine(s);
            }

            Console.WriteLine("LISTA NÚMERICA");
            var list = new List<int> { 1, 8, 9, 2, 3, 576, 73, 1, 23, 10 };

            var lista_ordenada =
                from l in list
                orderby l
                select l;

            foreach (var v in lista_ordenada)
            {
                Console.WriteLine(v);
            }
        }

    }
}

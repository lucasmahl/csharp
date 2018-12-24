using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjteto = "teste";

            meuObjteto = 3;
            meuObjteto++;

            Console.WriteLine(meuObjteto);

            //objetos q vc pode ir acrescentando
            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Fulano";
            aluno.nota = 8.5;
            aluno.idade = 26;

            Console.WriteLine($"{aluno.nome}, {aluno.nota}, {aluno.idade}");

        }
    }
}

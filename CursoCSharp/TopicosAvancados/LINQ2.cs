using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno(){Nome="Pedro",Idade=24,Nota=6.5},
                new Aluno(){Nome="André",Idade=25,Nota=6},
                new Aluno(){Nome="Julia",Idade=20,Nota=4.4},
                new Aluno(){Nome="Ana",Idade=31,Nota=5},
                new Aluno(){Nome="Ana",Idade=31,Nota=8},
                new Aluno(){Nome="João",Idade=29,Nota=10},
                new Aluno(){Nome="Marcio",Idade=19,Nota=9},
            };

            var pedro = alunos.Single(aluno=>aluno.Nome.Equals("Pedro"));

            Console.WriteLine($"{pedro.Nome}, nota: {pedro.Nota}!");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano==null)
            {
                Console.WriteLine($"Aluno inexistente");
            }

            var ana = alunos.First(aluno=>aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nome + " " + ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano==null)
            {
                Console.WriteLine("Aluno inexistente.");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            //skip pula 1,take pega 3
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var ek in exemploSkip)
            {
                Console.WriteLine(ek.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorio = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorio);


            /*var mediaDaTurma = alunos.Where(a => a.Nota >= 6).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);*/
            var mediaDaTurma = alunos.Where(a=>a.Nota>=6).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}

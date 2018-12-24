using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno(){Nome="Pedro",Idade=24,Nota=6.5},
                new Aluno(){Nome="André",Idade=25,Nota=6},
                new Aluno(){Nome="Julia",Idade=20,Nota=4.4},
                new Aluno(){Nome="Ana",Idade=31,Nota=5},
                new Aluno(){Nome="João",Idade=29,Nota=10},
                new Aluno(){Nome="Marcio",Idade=19,Nota=9},
            };

            Console.WriteLine("===APROVADOS===");
            //chama o aluno de a
            // var aprovados = alunos.Where(a => true);
            //var aprovados = alunos.Where(a => a.Idade>28);
            //var aprovados = alunos.Where(a => true).OrderBy(a => a.Nota) ;
            //var aprovados = alunos.Where(a => a.Nota>=6).OrderBy(a => a.Nota) ;
            //pela ordem de menor nota para a maior
            var aprovados = alunos.Where(a => a.Nota>=6).OrderBy(a => -a.Nota) ;

            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n ==== CHAMADA ====");
            //TRANSFORMANDO A LISTA DE ALUNOS EM LISTA DE STRINGS

            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n ====== APROVADOS POR IDADE ======");

            //lista de strings, também
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 6
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVSReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            numero++;
            Console.WriteLine($"{numero} e {copiaNumero}");

            Dependente Dep = new Dependente { Nome = "Beto", Idade = 20 };

            Dependente copiaDep = Dep;

            Console.WriteLine($"{Dep.Nome} e {copiaDep.Nome}");
            Console.WriteLine($"{Dep.Idade} e {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            Dep.Idade = 25;

            Console.WriteLine($"{Dep.Nome} e {copiaDep.Nome}");
            Console.WriteLine($"{Dep.Idade} e {copiaDep.Idade}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] Pessoas)
        {
            foreach(var pessoa in Pessoas)
            {
                Console.WriteLine($"Olá, {pessoa}!");
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger","Ana","Bia");
        }
    }
}

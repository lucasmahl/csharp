using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um Instagram!";

        //heranca
        protected string CorDoOlho = "Verde";

        //mesmo projeto (mesmo assembly)
        internal ulong NumeroCelular = 5511999999999;//ulong não tem sinal

        //heranca ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //mesma classe, ou heranca no mesmo projeto (c# > 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade.");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}

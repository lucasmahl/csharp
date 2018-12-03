using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true,
                'M'
            };

            arraylist.Add(3.25);
            Console.WriteLine(arraylist.Count); ;
            //pode ser usado object no lugar do var
            foreach(object item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }

        }
    }
}

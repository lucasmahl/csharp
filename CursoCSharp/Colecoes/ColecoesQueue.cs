using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            
            Console.WriteLine(fila.Peek());//mostra o primeiro
            Console.WriteLine(fila.Count);

            //fila.Dequeue();
            Console.WriteLine(fila.Count);

            foreach (object pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(2);
            salada.Enqueue("Item");
            salada.Enqueue(false);
            salada.Enqueue(2.14);

            Console.WriteLine(salada.Contains("Item"));
        }
    }
}

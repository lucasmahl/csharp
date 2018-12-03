using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        public static void Executar()
        {
            var Pilha = new Stack();


            Pilha.Push(3);
            Pilha.Push('M');
            Pilha.Push(false);
            Pilha.Push("Lucão");
            Pilha.Push(3.15f);

            foreach(var item in Pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\n Pop: {Pilha.Pop()}");

            foreach (var item in Pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\n Peek: {Pilha.Peek()}");
            Console.WriteLine($"\n Peek: {Pilha.Count}");
        }
    }
}

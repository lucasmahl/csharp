using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar(){
            var Saudacao = "Olá ".ToUpper().Insert(3, " world!").Replace("OLÁ", "Hello");

            Console.WriteLine(Saudacao);

            string valorImportante = "lucas";
            Console.WriteLine(valorImportante?.Length);
        }
    }
}

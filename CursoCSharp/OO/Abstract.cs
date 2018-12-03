﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "TRIM TRIM...";
        }
    }

    public class Samsung : Celular
    {

        public override string Assistente()
        {
            return "Olá meu nome é Bixby!";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Olá, meu nome é Siri!";
        }
    }
    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new IPhone(),
                new Samsung(),
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular);
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}

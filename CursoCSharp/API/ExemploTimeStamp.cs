using System;
using System.Collections.Generic;
using System.Text;


namespace CursoCSharp.API
{
    class ExemploTimeStamp
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            //var intervalo2 = new TimeSpan(10,20,30,40);

            Console.WriteLine(intervalo);
            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo);
            Console.WriteLine("Duração: " + tempo.GetType().Name);


            Console.WriteLine("Intervalo: " + intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo);
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo);

            Console.WriteLine("Tostring 1: " + intervalo.ToString("g"));
            Console.WriteLine("Tostring 2: " + intervalo.ToString("G"));
            Console.WriteLine("Tostring 3: " + intervalo.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalHours );
        }
    }
}

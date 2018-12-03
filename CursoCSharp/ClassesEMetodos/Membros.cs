using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa Fulano = new Pessoa();
            Fulano.Nome = "Luck";
            Fulano.Idade = 26;

            //Console.WriteLine($"{Fulano.Nome} tem {Fulano.Idade}!");

            Fulano.ApresentarConsole();

            var Sicrano = new Pessoa();
            Sicrano.Nome = "João";
            Sicrano.Idade = 20;

            var apresentacaoDoSicrano = Sicrano.Apresentar();
            Console.WriteLine(apresentacaoDoSicrano.Length);
            Console.WriteLine(apresentacaoDoSicrano);
            Sicrano.Zerar();
            Sicrano.ApresentarConsole();

        }
    }
}

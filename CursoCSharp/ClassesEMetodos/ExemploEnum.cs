using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero{Acao, Terror, Anime, Aventura, Comedia}
        
    public class Filme
    {
        public string titulo;
        public Genero GeneroDeFilme;

    }
    class ExemploEnum
    {
        public static void Executar()
        {
            //convertendo enum pra inteiro
            int id = (int)Genero.Anime;

            Console.WriteLine(id);

            var filmePraFamila = new Filme();

            filmePraFamila.titulo = "Sharknado";
            filmePraFamila.GeneroDeFilme = Genero.Comedia;

            Console.WriteLine("{0} e {1}", filmePraFamila.titulo, filmePraFamila.GeneroDeFilme);
        }
    }
}

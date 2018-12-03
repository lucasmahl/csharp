using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não reconhecido");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);//só qndo se está no mesmo projeto
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);//só por heranca
            //Console.WriteLine(UsaMuitoPhotoshop);//privado

        }
    }

    //tem a mesma composição, mas não está no mesmo projeto
    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo distante");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos); //herança
            //Console.WriteLine(amiga.numerodocelular); //internal
            //Console.WriteLine(amiga.jeitodefalar);//internal e protected, heranca ou mesmo projeto
            //Console.WriteLine(amiga.segredodefamilia);
            //Console.WriteLine(amiga.usamuitophotoshop);
            //Console.WriteLine(amiga.MeusAcessos);
        }
    }



    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();

            sub.MeusAcessos();

            //instancia e já executa
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}

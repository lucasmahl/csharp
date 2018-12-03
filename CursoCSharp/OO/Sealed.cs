using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    //não é possível herdar de uma classe celada
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_258_265.55;
        }
    }

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public new bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorDaFortuna());

            FilhoRebelde filhorebelde = new FilhoRebelde();
            Console.WriteLine(filhorebelde.HonrarNomeFamilia());
        }
    }
}

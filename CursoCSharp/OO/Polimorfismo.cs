using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        //construtor
        public Comida(double peso)
        {
            Peso = peso;
        }

        //construtor padrao
        public Comida() { }
    }

    public class Feijao : Comida{
        public Feijao(double peso) : base(peso)
        {

        }
    }

    public class Arroz : Comida
    {

    }

    public class Carne : Comida
    {

    }

    public class Pessoa
    {
        public double Peso;

        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }
    }

    class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ing1 = new Feijao(0.3);
            //ing1.Peso = 0.3;

            Arroz ing2 = new Arroz();
            ing2.Peso = 0.25;

            Carne ing3 = new Carne();
            ing3.Peso = 0.3;

            Pessoa Cliente = new Pessoa();
            Cliente.Peso = 80.2;

            Cliente.Comer(ing1);
            Cliente.Comer(ing2);
            Cliente.Comer(ing3);

            Console.WriteLine($"O peso do cliente é {Cliente.Peso}");
        }
    }
}

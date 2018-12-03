using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        //protected = será transmitida por herança
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;//privado por padrão

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int Delta)
        {
            int novaVelocidade = VelocidadeAtual + Delta;

            if (novaVelocidade<0)
            {
                VelocidadeAtual = 0;
            }else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //VIRTUAL para metodo poder ser reescrito
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        //construtor
        //recebe 200 de velocidade máxima
        public Uno() : base(200) {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350){
        
        }

        //sobreescreve o código da classe pai
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        //ocultado o metodo frear da classe pai
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno car1 = new Uno();
            Console.WriteLine(car1.Acelerar());
            Console.WriteLine(car1.Acelerar());
            Console.WriteLine(car1.Frear());
            Console.WriteLine(car1.Frear());
            Console.WriteLine(car1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari car2 = new Ferrari();
            Console.WriteLine(car2.Acelerar());
            Console.WriteLine(car2.Acelerar());
            Console.WriteLine(car2.Frear());
            Console.WriteLine(car2.Frear());
            Console.WriteLine(car2.Frear());

            Console.WriteLine("Polimorfismo");
            Console.WriteLine("Ferrari do tipo carro");
            Carro car3 = new Ferrari();
            //chama o override da classe ferrari
            Console.WriteLine(car3.Acelerar());
            Console.WriteLine(car3.Acelerar());
            //chama o frear da classe carro
            Console.WriteLine(car3.Frear());
            Console.WriteLine(car3.Frear());
            Console.WriteLine(car3.Frear());


        }
    }
}

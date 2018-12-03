using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional{
        //privado
        double desconto = 0.1;

        //privado
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }
            //propriedade autoimplementada
            public double Preco{ get; set; }

            //somente leitura
            public double precoComDesconto{
            get => Preco - (desconto * Preco);//lamda

                //get {
                //    return Preco - (desconto * Preco);
                //}
            }
            
            public CarroOpcional()
            {

            }
            
            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3599.98);
            Console.WriteLine(op1.precoComDesconto);
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
        }
    }
}

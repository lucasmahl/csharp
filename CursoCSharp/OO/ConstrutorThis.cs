using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        //construtor
        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro de {nome}, inicializado!");
        }

        //pega o nome da própria classe
        public Cachorro(string nome, double altura):this(nome){
            Altura = altura;
        }

        //converte pra string
        public override string ToString()
        {
            return $"Cachorro {Nome} tem {Altura}cm de altura!";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var rex = new Cachorro("Rex", 37.5);

            Console.WriteLine(spike);
            //Console.WriteLine(rex.ToString());
            Console.WriteLine(rex);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro{
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //construtor
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {
            //construtor padrao
        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var Carro1 = new Carro();
            Carro1.Fabricante = "BMW";
            Carro1.Modelo = "325i";
            Carro1.Ano = 2017;
            
            Console.WriteLine(
                $"{Carro1.Fabricante}, {Carro1.Modelo}, {Carro1.Ano}"
            );

            var carro2 = new Carro("Fusca","Volkswagen",1974);

            Console.WriteLine($"{carro2.Modelo}, {carro2.Fabricante}, {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
        }
    }
}

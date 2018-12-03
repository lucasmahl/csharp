using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("idade? ");
            int idade = int.Parse(Console.ReadLine());//Console.ReadLine retorna string, é preciso passar idade para int

            Console.WriteLine("Salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            //CultureInfo.InvariantCulture desconsidera a virgula como separador decimal

            Console.WriteLine($"Nome: {nome}, Idade: {idade} e salário: R${salario}!");
        }
    }
}

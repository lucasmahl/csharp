using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.9;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}",notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);

            Console.WriteLine($"Idade int: {idadeInt}");

            idadeInt = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado {0}", idadeInt);

            Console.Write("Digite um número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra,out numero);//converta a "palavra" e jogue no "numero"
            //int.TryParse(palavra,out int numero);//"numero" pode ser declarada e iniciada dentro desta funcao

            Console.WriteLine("Numero " + numero);

            Console.Write("Segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Número2: {numero2}");
        }
    }
}

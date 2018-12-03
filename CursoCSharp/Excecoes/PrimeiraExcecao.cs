using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_245.25);//underscore é opcional

            try
            {
                //int.Parse("def");

                conta.Sacar(1500);
                Console.WriteLine("Sacou, com sucesso!");
            }
            catch (Exception ex)//ArgumentException ou Exception
            {
                Console.WriteLine(ex.GetType().Name);//mostra o erro do tipo da variavel
                Console.WriteLine(ex.Message);
            }
            finally//é executado em qualquer situação
            {
                Console.WriteLine("Obrigado!");
            }


        }
    }
}

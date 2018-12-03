using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException(){ }

        public NegativoException(string message) : base(message){ }

        public NegativoException(string message, Exception inner) : base(message, inner){ }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random rand = new Random();
            int valor = rand.Next(-30,31);

            if (valor < 0)
            {
                throw new NegativoException("Número negativo :(");
            }
            if (valor%2==1)
            {
                throw new ImparException("Valor ímpar :(");
            }
            return valor;
        }



        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ux)
            {
                Console.WriteLine(ux.Message);
            }
            catch(ImparException ex)//ex é o parametro do bloco de baixo
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

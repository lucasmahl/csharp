using System;
using System.IO;

namespace CursoCSharp.API
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendoArquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Quantidade");
                    sw.WriteLine("Caneta Bic;1.90;126");
                    sw.WriteLine("Borracha branca;1.50;25");
                }

            }
            try{
                using (StreamReader sr = new StreamReader(path))
                {
                    //readtoend = eia o arquivo completamente
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

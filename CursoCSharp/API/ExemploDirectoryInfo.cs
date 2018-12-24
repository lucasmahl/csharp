using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            Console.WriteLine(dirInfo);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine(" ===     ARQUIVOS    === ");

            var arquivos = dirInfo.GetFiles();

            foreach (var arq in arquivos)
            {
                Console.WriteLine(arq);
            }
            Console.WriteLine("\n ===     DIRETÓRIOS    === ");

            var pastas = dirInfo.GetDirectories();

            foreach (var pst in pastas)
            {
                Console.WriteLine(pst);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Parent.Parent);
            Console.WriteLine(dirInfo.Root);
        }
    }
}

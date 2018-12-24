using System;
using System.IO;

namespace CursoCSharp.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCursoCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCursoCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);//true => ele exclui de forma recursiva
            }
            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));
            Console.WriteLine("============PASTAS=============");

            var pastas = Directory.GetDirectories(dirProjeto);
            Console.WriteLine(pastas);

            foreach (var pst in pastas)
            {
                Console.WriteLine(pst);
            }

            Console.WriteLine("\n ==========ARQUIVOS========== \n");

            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arq in arquivos)
            {
                Console.WriteLine(arq);
            }
            Console.WriteLine("\n ====RAÍZ==== \n");

            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            //move novodir para novodirdestino
            Directory.Move(novoDir, novoDirDestino);
        }
    }
}

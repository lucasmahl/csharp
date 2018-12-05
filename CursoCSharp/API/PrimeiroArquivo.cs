using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~",home);
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //@ serve para quando for utilizar /
            //~ se refere a pasta home do usuário exemplo @"~\teste\arquivo.txt";
            var path = @"~\arquivo_curso_csharp.txt".ParseHome();

            Console.WriteLine(path);
            
            //se o caminho do path não existe
            if (!File.Exists(path))
            {
                //entao ele cria
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Este é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo");
                    sw.WriteLine(":)");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais");
                sw.WriteLine("texto!");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDicionario
    {
        public static void Executar()
        {
            //a chave não pode ser repetida, mas o valor sim
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Gladiador");
            filmes.Add(2018, "Venom");
            filmes.Add(2004, "Os Incríveis");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine(filmes[2004]);
                Console.WriteLine(filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Gladiador"));

            Console.WriteLine($"Remover? {filmes.Remove(2004)}");

            filmes.TryGetValue(2004, out string filme2004);
            Console.WriteLine($"Filme {filme2004}!");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string>filme in filmes)
            {
                Console.WriteLine($"{filme.Value}, de {filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value}, de {filme.Key}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Colecoes
{
    class Dictionary
    {
        public static void Executar()
        {
            var filmes =  new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homens-Aranhas");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine($"2004: {filmes[2004]}");
                Console.WriteLine($"2004: {filmes.GetValueOrDefault(2004)}" );
            }


            Console.WriteLine(filmes.ContainsValue("Anminesia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);//passa o valor para uma variavel (neste caso ele recebe O grande Truque
            Console.WriteLine($"Filme {filme2006}");

            foreach (var Chave in filmes.Keys)//passa por todas as chaves
            {
                Console.WriteLine(Chave);
            }

            foreach (var Valor in filmes.Values)//passa por todos os valores
            {
                Console.WriteLine(Valor);
            }

            foreach(KeyValuePair<int, string> filme in filmes)//passa a chave e o valor para a variavel filme
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}

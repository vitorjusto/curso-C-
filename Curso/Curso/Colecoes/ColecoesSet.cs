using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Livro", 100.00);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);
            var combo = new HashSet<Produto>
            {
                new Produto("Livro2", 123.0),
                new Produto("Livro3", 145.0),
                new Produto("Livro4", 456.0),


            };

            //carrinho.AddRange(combo);
            carrinho.UnionWith(combo);//é assim que combina sets, já que não aceita repetição
            Console.WriteLine(carrinho.Count);

            //carrinho.RemoveAt(2);//ele não é indexsável portanto possui algumas limitações
            foreach (var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine("\n\n" + carrinho.Count);
            carrinho.Add(livro);//ele não aceita repetição
            Console.WriteLine(carrinho.Count);


        }
    }
}

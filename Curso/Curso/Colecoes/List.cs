using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)//alteração referente a aula Igualdade
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco; 
        }
    }

    class List
    {
        public static void Executar()
        {
            var livro = new Produto("Livro", 100.00);

            var carrinho = new List<Produto>();//a lista caso ele pode amarzenar ideterminadas dados
            carrinho.Add(livro);
            var combo = new List<Produto>
            {
                new Produto("Livro2", 123.0),
                new Produto("Livro3", 145.0),
                new Produto("Livro4", 456.0),


            };

            carrinho.AddRange(combo);//ele adiciona novos elementos de uma array em uma array, ao invés de deixar uma array dentro
            Console.WriteLine(carrinho.Count);

            carrinho.RemoveAt(2);//ele remove a partir do index

            foreach(var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));//ele procura a posição do item
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine("\n\n" +carrinho.Count);
            carrinho.Add(livro);//ele aceita repetição
            Console.WriteLine(carrinho.Count);


            
        }
    }
        
}

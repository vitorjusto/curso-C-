using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{

    public  class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto;//agora o desconto pertence a classe e não as estancias

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        

        

        public double CalcularDesconto()
        {
            return Preco * (1 - Desconto);
        }
    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 10);//idependete do terceiro valor o desconto vai ser sempre o mesmo
            var produto2 = new Produto("borracha", 5.2, 0.1);

            Console.WriteLine("Preço com desconto: " + produto1.CalcularDesconto().ToString("C"));
            Console.WriteLine("Preço com desconto: " + produto2.CalcularDesconto().ToString("C"));

            Produto.Desconto = 0.2;
            Console.WriteLine("Preço com desconto: " + produto1.CalcularDesconto().ToString("C"));
            Console.WriteLine("Preço com desconto: " + produto2.CalcularDesconto().ToString("C"));

        }
    }
}

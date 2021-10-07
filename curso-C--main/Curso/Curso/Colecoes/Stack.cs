using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Colecoes
{
    class Stack
    {
        public static void Executar()
        {
            var pilha = new Stack<string>();

            pilha.Push("Vitor");
            pilha.Push("Hugo");
            pilha.Push("Cardoso");
            pilha.Push("Justo");

            foreach(var item in pilha)
            {
                Console.Write($"{item}  ");

            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item}  ");

            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}

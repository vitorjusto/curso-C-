using System;
using System.Collections.Generic;
using System.Collections;

namespace Curso.Colecoes
{
    class Queue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("fulano");
            fila.Enqueue("sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());//exibe a ponta da fila(o primeiro)
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Peek());

            foreach (var x in fila)
            {
                Console.WriteLine(x);
            }

            /*
            var salada = new Queue();//prescisa do System.Collections
            salada.Enqueue(3);
            salada.Enqueue("item");
            */

        }
    }
}

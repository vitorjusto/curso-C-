using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class Break
    {
        public static void Executar()
        {
            Random random = new Random();

            int numero = random.Next(1, 101);

            for(int i = 1; i <=100; i++)
            {
                Console.WriteLine($"{i} é o numnero que queremos?");

                if (i == numero)
                {
                    Console.WriteLine("Sim ");
                    break;
                }else
                {
                    Console.WriteLine("Não \n\n");

                }

                
            }
        }
    }
}

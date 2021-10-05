using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class Do_While
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual o Seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo");
                Console.WriteLine("Deseja continuar(S/N)");

            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class If_Else
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a sua nota");
            double.TryParse(Console.ReadLine(), out double nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação");
            }
            else
            {
                Console.WriteLine("Recuperação");
                Console.WriteLine("Feio");
            }


        }
    }
}

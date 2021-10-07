using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class If_Else_If
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno");

            double.TryParse(Console.ReadLine(), out double nota);

            if (nota >= 9.0 && nota <= 10.0)
            {
                Console.WriteLine("Quadro de Honra!");

            }
            else if (nota >= 7.0 && nota < 9)
            {
                Console.WriteLine("Aprovado");

            }
            else if (nota <= 5.0)
            {
                Console.WriteLine("Recuperação");

            }
            else
            {
                Console.WriteLine("Te vejo na proxima");
            }

            Console.WriteLine("Fim!!");
        }
    }
}

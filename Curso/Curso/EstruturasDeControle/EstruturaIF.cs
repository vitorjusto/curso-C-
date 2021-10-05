using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {


            if(3 < 4)
            {
                Console.WriteLine("3 é menor que 4");
            }


            Console.WriteLine("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("O aluno é comportado?(S/N) ");
            string comportamento = Console.ReadLine();

            if(nota >= 7)
            {
                Console.Write("O aluno foi aprovado");
                if (comportamento.ToUpper() == "S")
                    Console.Write(" e ele é bem comportado");
                else
                    Console.Write(" mas ele não é comportado");
            }else
            {
                Console.Write("O aluno foi aprovado");
                if (comportamento.ToUpper() == "S")
                    Console.Write(" mas ele é bem comportado");
                else
                    Console.Write(" e ele não é comportado");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class For
    {
        public static void Executar()
        {
           

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine("{0} * 2 = {1}", i, i * 2);
            }


            double somatorio = 0.0;
            double nota;
            int tamanhoTurma;
            double media;
            Console.WriteLine("Digite o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out tamanhoTurma);


            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine($"Digite a nota da {i}° aluno");
                double.TryParse(Console.ReadLine(), out nota);
                somatorio += nota;
            }

            media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0; 

            Console.WriteLine($"A sala ficou com média de {media}");

           
        }
    }
}

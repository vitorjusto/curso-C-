using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class Switch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie a nota do atendimento 1 - 5");
            byte.TryParse(Console.ReadLine(), out byte nota);


            switch (nota)
            {
                case 5:

                    Console.WriteLine("Excelente");
                    break;
                case 4:
                    Console.WriteLine("Ótimo");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 1:
                    Console.WriteLine("péssimo");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }


        }
    }
}

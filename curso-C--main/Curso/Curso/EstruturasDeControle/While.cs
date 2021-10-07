using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class While
    {
        public static void Executar()
        {
            int palpite = 0;
            int tentativas = 0;
            Random random = new Random();


            int numeroSecreto = random.Next(1, 16);


            while (true)
            {
                Console.WriteLine("Digite um numero");
                int.TryParse(Console.ReadLine(), out palpite);

                tentativas++;

                if (palpite == numeroSecreto)
                {


                    Console.WriteLine("Parabens você adivinhou em {0} tentativas!!", tentativas);

                    break;
                }
                else if (palpite < 0 || palpite > 15)
                {

                    Console.WriteLine("O numero é entre 1 e 15");


                    tentativas--;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O numero Secreto é menor");
                }
                else
                {
                    Console.WriteLine("O numero Secreto é maior");
                }
            }
        }
    }
}

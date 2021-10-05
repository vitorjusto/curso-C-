using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            Console.WriteLine("Digite se o trabalho de terça deu certo(S/N)");

            bool ter = Console.ReadLine().ToUpper() == "S" ? true : false;

            Console.WriteLine("Digite se o trabalho de Quinta deu certo(S/N)");
            bool qui = Console.ReadLine().ToUpper() == "S" ? true : false;

            Console.WriteLine("A televisão de 50 polegas vai comprar? {0}", ter && qui);
            Console.WriteLine("O sorvete vai comprar? {0}", ter || qui);
            Console.WriteLine("A televisão de 32 polegas vai comprar? {0}", ter ^ qui);// porta Xor
            Console.WriteLine("Mais saudavel? {0}", !(ter || qui));

        }
    }
}

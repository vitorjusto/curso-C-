using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Fundamentos
{
    class OperadoresUnario
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);


            numero1++;
            Console.WriteLine(numero1);
            Console.WriteLine(numero1++);

            
            Console.WriteLine(--numero2);

            numero1 = 2;
            numero2 = 3;
            Console.WriteLine(numero1++ == --numero2);//o numero1 vai incrementar depois da comparação enquanto o numero2 vai incrementar antes

        }
    }
}

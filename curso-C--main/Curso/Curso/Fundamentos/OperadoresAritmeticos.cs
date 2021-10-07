using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = (preco + imposto) * (1 - desconto);
            Console.WriteLine("O preço final é: " + total);

            //imc
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("O imc é: {0}", imc.ToString("F2"));

            //impar ou par
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/ 2 tem resto {1} e {2}/2 tem resto {3}", par, par % 2, impar, impar % 2);

        }
    }
}

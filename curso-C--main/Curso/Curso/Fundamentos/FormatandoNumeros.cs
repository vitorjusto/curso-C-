using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Curso.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//ele arredonda a quantidade de casas decimais
            Console.WriteLine(valor.ToString("C"));//C = current (muda para valores monetários)
            Console.WriteLine(valor.ToString("P"));//P = percent (muda para valores percentuais)
            Console.WriteLine(valor.ToString("#.##"));//coloca a quantidade de casas dependendo das #


            CultureInfo cultura = new CultureInfo("pt-BR");//ele colooca as formatações de numero em pt-Br

            Console.WriteLine(valor.ToString("C2", cultura));


            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D3"));//coloca a quantidade de numeros inteiros e o que sobrar var virar 0 a esquerda

        }    
    }
}

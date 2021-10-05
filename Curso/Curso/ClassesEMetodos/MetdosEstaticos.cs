using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class MetdosEstaticos
    {
        public class CalculadoraEstatica
        {
            public static int Somar(int a, int b)//pode acessar diretamente sem prescisar de estancia
            {
                return a + b;
            }

            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }

        public static void Executar()
        {
                var resultado = CalculadoraEstatica.Multiplicar(2, 2);//ele pode ser acessado a partir da classe
                Console.WriteLine("Resultado " + resultado);

                CalculadoraEstatica calc = new CalculadoraEstatica();

                //calc.Somar(1, 2);
                resultado = CalculadoraEstatica.Somar(1, 2);

                Console.WriteLine(resultado);
            
        }

        



    }
}

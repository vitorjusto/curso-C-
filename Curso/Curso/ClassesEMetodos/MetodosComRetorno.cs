using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class CalculadoraComun
    {
        public int Somar(int c, int d)
        {
            return c + d;
        }
        
        public int Somar(double a, int b)//tem problema se colocar a mesma quantidades de tipos iguais se os nomes forem iguais
        {
            return (int)a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            return a / b;
        }

    }


    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a)
        
        {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calcular = new CalculadoraComun();

            Console.WriteLine(calcular.Somar(2, 3));
            Console.WriteLine(calcular.Subtrair(2, 3));
            Console.WriteLine(calcular.Multplicar(2, 3));
            Console.WriteLine(calcular.Dividir(5, 3));


            Console.WriteLine("Calculadora Cadeia");

            var calcularCadeia = new CalculadoraCadeia();

            calcularCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();


            var calculo = new CalculadoraCadeia();

            int resultado = calculo.Somar(2).Subtrair(3).Somar(5).Multiplicar(3).Dividir(2).Resultado();

            Console.WriteLine(resultado);
        }
    }
}

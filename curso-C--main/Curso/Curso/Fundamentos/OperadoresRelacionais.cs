using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Fundamentos
{
    class OperadoresRelacionais
    {

        public static void Executar()
        {
            double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out nota);

            double notaDeCorte = 7.0;

            Console.WriteLine("Nota Válida: {0}", nota < 10.0 || nota > 0.00);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota < 3.0);
        }
    }
}

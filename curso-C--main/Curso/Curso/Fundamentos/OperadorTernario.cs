using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno");
            float.TryParse(Console.ReadLine(), out float nota);
            var resultado = nota < 10 && nota > 0? (nota >= 7.0 ? "O aluno foi Apovrado" : "O aluno foi Reprovado" ): "Nota inválida";

            Console.WriteLine(resultado);
        }
    }
}

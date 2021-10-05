using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.EstruturasDeControle
{
    class ForEach
    {
        public static void Executar()
        {
            var palavra = "opa!";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }


            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach(var nome in alunos)
            {
                Console.WriteLine(nome);
            }
        }
    }
}

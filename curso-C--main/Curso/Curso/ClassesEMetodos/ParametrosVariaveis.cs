using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class ParametrosVariaveis
    {
        public static void Recepcionar(params string[] pessoas)//dá´para passar varios parametros em um método
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine($"Ola {pessoa}");
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia");
        }
    }
}

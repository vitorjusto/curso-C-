using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;//public é visivel para todos
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Ola o meu nome é {Nome} e tenho {Idade} anos "); 
        }
        
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Colecoes
{
    class igualdade
    {



        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);

            Console.WriteLine(p1 == p2);//neste caso da falso porque ele aponta referencias diferentes 

            Console.WriteLine(p1.Equals(p2));//aqui tbm, aqui faz a mesma coisa, neste caso teve que alterar o codigo origial para funcionar como desejado (feito no arquivo List.cs)

           
        }
    }
}

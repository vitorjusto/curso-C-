using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class ParametroPadrao
    {

        public static int Somar(int a = 1, int b = 1)//não prescisa passar valor, como padrao ele terá
        {
            return a + b;
        }
        public static void Executar()
        {
            int soma = Somar();//aqui não prescisa de passar valor, beste caso os valores dos dois será 1

            Console.WriteLine(soma);
            Console.WriteLine(Somar(2, 3));
            Console.WriteLine(Somar(b: 3));//neste caso a variavel b tera 3 e a a terá o valor padrão
        }
    }
}

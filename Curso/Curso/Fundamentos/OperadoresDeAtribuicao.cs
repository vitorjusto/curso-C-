using System;

namespace Curso.Fundamentos { 
class OperadoresAtribuição
{
    public static void Executar()
    {
            var num1 = 3.0;
            Console.WriteLine("Num = " + num1);
            
            num1 += 10;
            Console.WriteLine("Num += 10 = " + num1);
            num1 -= 5;
            Console.WriteLine("Num -= 5 = " + num1);
            num1 *= 3;
            Console.WriteLine("Num *= 3  = " + num1);
            num1 /= 2;
            Console.WriteLine("Num /= 2 = " + num1);

            int a = 1;
            int b = a;

            a++;
            b--;
            Console.WriteLine("a++ = {0} e b-- = {1}", a, b);

          

    }
}
}

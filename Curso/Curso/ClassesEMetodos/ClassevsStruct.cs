using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;

        public CPonto(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class ClassevsStruct
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 2 };
            SPonto copiaPonto1 = ponto1;//Atribuição por valor
            copiaPonto1.X = 4;
            
            Console.WriteLine("ponto 1: " + ponto1.X);
            Console.WriteLine("copia ponto 1: " + copiaPonto1.X);

            CPonto ponto2 = new CPonto(1, 2);
            CPonto copiaPonto2 = ponto2;
            copiaPonto2.Y = 3;//se eu alterar um atributo da classe altera o objeto original, no struct não

            Console.WriteLine("ponto 2: " + ponto2.Y);
            Console.WriteLine("copia ponto 2: " + copiaPonto2.Y);


        }
    }
}

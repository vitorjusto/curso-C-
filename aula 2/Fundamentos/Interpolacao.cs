using System;
using System.Collections.Generic;
using System.Text;

namespace aula_2.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "notebook gamer";
            string marca = "Dell";
            double preco = 5000.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco);
            Console.WriteLine("o notebook {0} da marca {1} custa {2}", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é legal");
            Console.WriteLine($"1 + 1 = {1+1}");
        }
    }
}

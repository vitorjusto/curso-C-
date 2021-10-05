using System;
using System.Collections.Generic;
using System.Text;

namespace aula_2.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola ".ToUpper().Insert(4, "World").Replace("World", "Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("".Length);
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);//vai dar erro pq está vazia por isso tem o ponto de interrogação, ele evita o erro
        
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{

    class ParametrosPorReferencias
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero)//aqui ele não recebe nada do B apenas dá o valor para ele
        {
            numero = 0;//neste caso já que ele não recebe valor ele prescisa inicializar
            numero = numero + 15;
        }


        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);//com o ref, se alterar o valor em outro lugar sem prescisar de return, semelhante ao ponteiro em C 

            int b = 2;
            AlterarOut(out b);//o B ele só vai receber a saida, idependente do valor que ele tiver ele não vai entrar
            Console.WriteLine($"O valor de A = {a} \nO valor de B = {b}");
        
            //assim como o ponteiro os dois podem retornar varios valores sem prescisar do return 
        }
    }
}

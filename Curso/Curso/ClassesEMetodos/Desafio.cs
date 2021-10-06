using System;
using System.Collections.Generic;
using System.Text;

/*
 * 
 * o desafio é acessar o atributo A sem mecher nela
 * tem que ser dentro de executar
 */




namespace Curso.ClassesEMetodos
{
    class Desafio
    {
        int a = 10;
        public static void Executar()
        {
            Desafio teste = new Desafio();
            Console.WriteLine(teste.a);
        }
    }
}

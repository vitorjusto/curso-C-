using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];//ATENÇÃO: nesta linguagem, o array não pode ter varios tipos no mesmo array
                                            //e a quantidade dele é fixa, uma vez criada com cinco posições SEMPRE terá cinco posições
            alunos[0] = "Vitor";
            alunos[1] = "hugo";
            alunos[2] = "Cardoso";
            alunos[3] = "ola";
            alunos[4] = "Justo";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            Console.WriteLine($"\n\nMédia = {somatorio/notas.Length}");//pode usar o Length

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);//converte um array de char para uma string

            Console.WriteLine(palavra);


        }
    }
}

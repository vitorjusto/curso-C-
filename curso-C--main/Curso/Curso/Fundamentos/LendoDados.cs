
using System;
using System.Globalization;

namespace Curso
{
    class LendoDados
    {
        public static void Executar()
        {


            Console.Write("Qual é o seu nome?  ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());//ele sempre lê como string enão prescisa converter


            Console.Write("Qual é o seu salario: ");
            float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//culture ele escreve se é ponto ou virgula dependendo da região colocada no sistema operacional


            Console.WriteLine($"{nome} tem {idade} de idade e ganha {salario} reais por mês");



        }
    }
}
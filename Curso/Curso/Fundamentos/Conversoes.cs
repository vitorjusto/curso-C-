using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(inteiro + "  " + quebrado);


            double nota = 9.12;
            int intnota = (int)nota;//convertendo Double para int 
            Console.WriteLine("Nota Truncada: {0}", intnota);


            Console.WriteLine("Digite a sua idade: ");
            string idade = Console.ReadLine();
            int intidade = int.Parse(idade);    //há duas maneiras de converter strings para numeros
            intidade = Convert.ToInt32(idade);
            Console.WriteLine("Idade inserida: {0}", intidade);


            Console.WriteLine("Digite um numero: ");
            string palavra = Console.ReadLine();
            int Numero;
            int.TryParse(palavra, out Numero);//ele vai tentar passar a string para um numero, se caso for letra a é = 0
            Console.WriteLine(Numero);

        }
    }
}

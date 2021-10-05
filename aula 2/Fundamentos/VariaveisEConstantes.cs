using System;
using System.Collections.Generic;
using System.Text;

namespace aula_2.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area de circuferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é: " + area);
            Console.WriteLine("a area é: " + area + 1000);//ele vai concatenar

            bool estaChuvendo = false;
            Console.WriteLine("Esta chovendo: " + estaChuvendo);

            byte idade = 45;//o byte é um int menor e não aceita valores negativos
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;//agora aceita valor negativo, neste caso ele vai receber o menor valor posssivel
            Console.WriteLine("saldo: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Sálario: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int: " + menorValorInt);

            uint populacaoBrasileira = 207600000; //uint ele não possui valores negativos
            Console.WriteLine("populacao brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long: " + menorValorLong);


            ulong populacaoMundial = 7_600_000_000;//long sem negativo, e dá para escrever numeros desse jeito para mais facil de entendimento
            Console.WriteLine("População mundial: " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço do computador: " + precoComputador);

            decimal distanciaEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancias das estrelas: " + distanciaEstrelas);

            char letra = 'd';//o char usa aspas simples
            Console.WriteLine("Letra: " + letra);

            string texto= "ola";
            Console.WriteLine("String: " + texto);



        }
    }
}

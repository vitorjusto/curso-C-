using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    public class Depedente
    {
        public string Nome;
        public int Idade;

    }



    class ValorVSReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            copiaNumero = 5;//o numero e copiaNumero são idependente, ou seja a copiaNumero apenas copiou o valor
            Console.WriteLine($"{numero} {copiaNumero}");

            Depedente dep = new Depedente
            {
                Nome = "Beto",
                Idade = 20
            };

            Depedente copiaDep = dep;//neste caso ele copiou a referencia, ou seja se um for alterado o outro também foi alterado

            copiaDep.Nome = "Vitor";
            copiaDep.Idade = 19;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

        }
    }
}

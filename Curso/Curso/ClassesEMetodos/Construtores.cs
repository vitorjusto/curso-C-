using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()//caso não tenha parametros
        {

        }
    }
    class Construtores
    {
        public static void Executar()
        {
            Carro carro1 = new Carro();

            
            carro1.Modelo = "325i";
            carro1.Fabricante = "BMW";
            carro1.Ano = 2017;
            
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");


            Carro carro2 = new Carro("31312", "fiat", 2013);//o construtor serve para enquando usada na estancia já pode colocar os atributos
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");


            var carro3 = new Carro()//outra forma de construir
            {
                Fabricante = "toyota",
                Modelo = "123454",
                Ano = 2022
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}

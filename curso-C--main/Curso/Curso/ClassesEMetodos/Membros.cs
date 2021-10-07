using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    class Membros
    {

        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Vitor";
            sicrano.Idade = 19;

            Console.WriteLine($"Nome: {sicrano.Nome} \nIdade: {sicrano.Idade}");
            Console.WriteLine(sicrano.Apresentar());
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();

            fulano.Nome = "Hugo";
            fulano.Idade = 20;

            var apresentacaoFulano = fulano.Apresentar();
            fulano.zerar();
            Console.WriteLine(fulano.Apresentar());


        }
    }
}

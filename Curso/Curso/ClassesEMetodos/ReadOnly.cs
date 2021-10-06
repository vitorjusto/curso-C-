using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;//tipo readonly

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        /*
        public void alterar(DateTime teste)
        {
            Nascimento = teste;//ele não deixa alterar  unico jeito de colocar um, valor é apenas no metodo construtor
        }*/
    
        public string GetDataDeNascimento()
        {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }

    

    class ReadOnly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(2002, 8, 19));

            //DateTime teste = novoCliente.Nascimento //ele é protegido fora da função

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}

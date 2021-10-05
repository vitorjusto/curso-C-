using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    public class CarroOpcional
    {


        double desconto = 0.1;

        string nome;

        public CarroOpcional()
        {

        }
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //popriedade autoiplementada
        public double Preco { get; set; }
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);//lambda 
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            //op1.PrecoComDesconto = 3000 //ele é somente leitura

            var op2 = new CarroOpcional();
            op2.Nome = "som";
            op2.Preco = 1234.5;


            Console.WriteLine(op2.Nome);//ele mostra o texto "opicional"
        }
    }
}

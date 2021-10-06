using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

 
        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)//ele não consegue altera velocidade direto
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if(novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;

        }

        
        public virtual int Acelerar()//o virtual deixa o metodo sobreescrito
        {
            return AlterarVelocidade(5);
        }

        public int frear()
        {
            return AlterarVelocidade(-5);
        }

    }
    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }
    public class Ferrari : Carro
    {
        public Ferrari() : base(300)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        public new int frear()
        {
            return AlterarVelocidade(-15);
        }

    }


    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");

            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());

            Console.WriteLine(carro1.frear());
            Console.WriteLine(carro1.frear());
            Console.WriteLine(carro1.frear());


            Console.WriteLine("Ferrari..");

            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.frear());
            Console.WriteLine(carro2.frear());
            Console.WriteLine(carro2.frear());

            Carro carro3 = new Ferrari();
            Console.WriteLine("ferrari 2");
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.frear());//aqui ele possui o metodo frear da classe pai e não o sobreescrito na classe filho por causa do "new"
            Console.WriteLine(carro3.frear());
            Console.WriteLine(carro3.frear());
        }
    }
}

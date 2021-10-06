using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    public class Computador
    {
        private string Os;
        private double Ram;
        private double DiscoRigido;

        public string GetOs()
        {
            return Os;
        }

        public void setOs(string os)
        {
            Os = os;
        }

        public double GetRam()
        {

            return Ram;
        }
        public void setRam(double ram)//geters e seters é bom para fazer correçoes de entradas individuais
        {
            if (ram >= 0)
            {
                Ram = ram;
            }else
            {
                Console.WriteLine("A memoria RAM deve ser positiva");
            }
        }
        public double GetDiscoRigido()
        {
            return DiscoRigido;
        }
        public void setDiscoRigido(double discoRigido)
        {
            DiscoRigido = discoRigido;
        }

        public string toString()
        {
            return $"{GetOs()} tem {GetRam()} Gb de RAM e {GetDiscoRigido()} Gb de disco rigido";
        }
    }

    class GeterseSeters
    {
        public static void Executar()
        {
            Computador c1 = new Computador();
            c1.setOs("Windows");
            c1.setRam(2);
            c1.setDiscoRigido(512);

            Console.WriteLine($"{c1.GetOs()} tem {c1.GetRam()} Gb de RAM e {c1.GetDiscoRigido()} Gb de disco rigido");
            Console.WriteLine(c1.toString());
            c1.setRam(-3);
        }
    }
}

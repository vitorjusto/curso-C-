using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);//deve ser publico que é por padrão
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    class Struct
    {


        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine($"X = {coordenadaInicial.X} e Y = {coordenadaInicial.Y}");


            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine($"X = {coordenadaFinal.X} e Y = {coordenadaFinal.Y}");
        }
    }

}

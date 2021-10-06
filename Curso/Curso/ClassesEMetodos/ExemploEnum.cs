using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia}//o enum pode servir como um seletor para evitar opções erradas (tipo avaliação do hotel 0-5 estrelas, a pessoa pode digitar 6) neste caso ele evita esse tipo de erro
    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Minions";
            filmeParaFamilia.GeneroDoFilme = Genero.Animacao;

            Console.WriteLine($"Titulo: {filmeParaFamilia.Titulo}\nGenero: {filmeParaFamilia.GeneroDoFilme}");
        }
    }
}

using CriandoClasse.src;
using System;

namespace CriandoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filmes Henrique = new Filmes(Gênero.Ficção, "Perdido em Marte", 10);
            Filmes Jéssica = new Filmes(Gênero.Suspense, "Um contra Tempo", 9.2);
            Filmes Jorge = new Filmes(Gênero.Ação, "Vingadores", 8.7);
            Filmes Larissa = new Filmes(Gênero.Aventura, "Homem Aranha", 8.7);

            Console.WriteLine(Henrique.ToString());
            Console.WriteLine(Jéssica.ToString());
            Console.WriteLine(Jorge.ToString());
            Console.WriteLine(Larissa.ToString());
            

            Filmes Carlos = new Filmes(Gênero.Romance);

            Console.WriteLine(Carlos);
        }
    }
}

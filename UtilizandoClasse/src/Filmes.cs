using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoClasse.src
{
    public class Filmes
    {
        public Gênero Gênero { get; set; }
        public string NomeDoFilme { get; set; }
        public double NotaDoFilme { get; set; }

        public Filmes(Gênero gênero)
        {
            Gênero = gênero;
        }

        public Filmes(Gênero gênero, string nomeDoFilme, double notaDoFilme)
        {
            Gênero = gênero;
            NomeDoFilme = nomeDoFilme;
            NotaDoFilme = notaDoFilme;
        }

        public override string ToString()
        {
            return 
                $"\n O gênero de filme que mais gosto é: {Gênero} " +
                $"\n Nome do Filme é: {NomeDoFilme} " +
                $"\n Minha nota para esse filme: {NotaDoFilme}";
        }
    }
    public enum Gênero
    {
        Ação, 
        Suspense,
        Ficção,
        Aventura,
        Romance
    }
}

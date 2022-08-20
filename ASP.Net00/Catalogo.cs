using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net00
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> Getlivros()
        {
            var Livros = new List<Livro>();
            Livros.Add(new Livro("Get rich or die trying", "002", 13.99));
            Livros.Add(new Livro("Assassin's Creed brotherhood", "003", 30.99));
            Livros.Add(new Livro("Toy Story", "004", 40.99));
            Livros.Add(new Livro("Pyetro no pais das maravilhas", "005", 9.99));
            Livros.Add(new Livro("Como vender bem e rapido", "006", 11.99));
            return Livros;
        }
    }
}

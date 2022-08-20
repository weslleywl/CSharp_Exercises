using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net00
{
    public class Livro
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public double Preco { get; set; }

        public Livro(string nome,string codigo,double preco)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Preco = preco;
        }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net00
{
    public class Relatorio : IRelatorio
    {
        private readonly ICatalogo catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            this.catalogo = catalogo;
        }
        public async Task Imprimir(HttpContext context)
        {
            foreach (var Livro in catalogo.Getlivros())
            {
                await context.Response.WriteAsync($"{Livro.Nome} COD : {Livro.Codigo,-10} {Livro.Preco.ToString("C")}\n");
            }
        }
    }
}

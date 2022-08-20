using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ASP.Net00
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}
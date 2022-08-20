using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescobrePorcentagem
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, desconto,valordesconto;
            Console.WriteLine("Digite qual foi o valor do produto comprado :");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o valor do desconto dado pelo vendedor :");
            desconto = double.Parse(Console.ReadLine());
            valordesconto =(desconto * 100) / (valor * 1);
            Console.WriteLine($"{desconto} Reais de desconto " +
                $"Equivale a {Math.Round(valordesconto,2)}% de {valor}");
            Console.ReadKey();
        }
    }
}

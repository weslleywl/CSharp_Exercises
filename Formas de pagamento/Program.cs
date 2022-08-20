using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Formas_de_pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 À vista em dinheiro ou cheque, recebe 10% de desconto
            //2 À vista no cartão de crédito, recebe 5% de desconto
            //3 Em 2 vezes, preço normal de etiqueta sem juros
            //4 Em 3 vezes, preço normal de etiqueta mais juros de 10%
            Console.WriteLine("-------------------------");
            Console.WriteLine("--Confira seu pagamento--");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Pagamentos p = new Pagamentos();
            Console.WriteLine("Qual foi o produto comprado ?");
            p.nomeproduto = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto comprado : ");
            Console.Write("Preço : ");
            p.valorProduto = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a forma de pagamento :");
            Console.WriteLine("1 - dinheiro ou cheque");
            Console.WriteLine("2 - cartão de crédito");
            Console.WriteLine("3 - parcelar em 2 vezes");
            Console.WriteLine("4 - parcelar em 3 vezes");
            Console.WriteLine();
            Console.Write("Código : ");
            p.codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor do juros à ser tributado : ");
            p.taxa = int.Parse(Console.ReadLine());
            while ((p.codigo != 1) && (p.codigo != 2) && (p.codigo != 3) && (p.codigo != 4))
            {
                Console.Write("Digite um código válido por favor : ");
                p.codigo = int.Parse(Console.ReadLine());
            }
            if (p.codigo == 1)
            {
                Console.WriteLine(p.avista());
            }
            else if (p.codigo == 2)
            {
                Console.WriteLine(p.cartao());
            }
            else if (p.codigo == 3)
            {
                Console.WriteLine(p.parcelax2());
            }
            else if (p.codigo == 4)
            {
                Console.WriteLine(p.parcelax3());
            }
        }
    }
}

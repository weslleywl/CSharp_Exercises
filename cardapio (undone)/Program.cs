using System;
using System.Xml.Schema;

namespace cardapio
{
    class Program
    {
        static void Main(string[] args)
        {
            //  escreval(" ***** CARDÁPIO ***** ")
            //escreval("cachorro quente , código 100")
            //escreval("bauru simples , código 101")
            //escreval("bauru com ovo , código 102")
            //escreval("hambueguer , código 103")
            //escreval("cheeseburguer , código 104")
            //escreval("refrigerante , código 105")
            //escreval("digite o código do item ")
            decimal codigo, quant;
            decimal total;
            Console.WriteLine(" ***** CARDÁPIO ***** ");
            Console.WriteLine("cachorro quente , código 100");
            Console.WriteLine("bauru simples , código 101");
            Console.WriteLine("bauru com ovo , código 102");
            Console.WriteLine("hambueguer , código 103");
            Console.WriteLine("cheeseburguer , código 104");
            Console.WriteLine("refrigerante , código 105");
            Console.WriteLine("digite o código do item ");
            Console.WriteLine();
            codigo = Convert.ToDecimal(Console.ReadLine());
            while ((codigo != 100) && (codigo != 101) && (codigo != 102) && (codigo != 103) && (codigo != 104) && (codigo != 105))
            {
                Console.WriteLine("Código inexistente,digite novamente :");
                codigo = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Qual é a quantidade desejada ?");
            quant = Convert.ToInt32(Console.ReadLine());
            if (codigo == 100)
            {
                var preco = 4 / 3;
                Console.WriteLine(preco);
            }
        }
    }
}

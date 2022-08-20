using System;

namespace testeclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O produto foi comprado em uma loja fisica ? ");
            Console.WriteLine("sim / nao");
            string resp = Console.ReadLine();
            if (resp == "sim")
            {
                Cadastro c = new Cadastro();
                Console.WriteLine("Qual é o seu produto ? ");
                c.nome = Console.ReadLine();
                Console.WriteLine("Qual é a marca do produto selecionado ? ");
                c.marca = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto :");
                c.valor = decimal.Parse(Console.ReadLine());
                Console.WriteLine(c.teste());
            }
            else
            {
                Virtual v = new Virtual();
                Console.WriteLine("Digite seu cpf :");
                v.cpf = Console.ReadLine();
                Console.WriteLine("Digite seu email :");
                v.email = Console.ReadLine();
                Console.WriteLine("Qual foi o produto de compra ?");
                v.nome = Console.ReadLine();
                Console.WriteLine("qual foi a marca do produto da compra ?");
                v.marca = Console.ReadLine();
                Console.WriteLine(v.online());

            }
        }
    }
}

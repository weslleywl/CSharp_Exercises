using System;

namespace dirigir_e_votar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ler ano de nasc - condições menor 16 - igual 16 - maior 16
            int nascimento, idade;
            string resp = "sim";
            while (resp != "nao")
            {
                Console.WriteLine("Digite o seu ano de nascimento : ");
                nascimento = int.Parse(Console.ReadLine());
                Console.WriteLine();
                idade = 2020 - nascimento;
                if (idade < 16)
                {
                    Console.WriteLine($"Você ainda não pode votar e nem dirigir,porque tem somente {idade} anos.");
                    Console.WriteLine();
                }
                else if ((idade >= 16) && (idade < 18))
                {
                    Console.WriteLine($"Você pode votar mas ainda não pode dirigir,porque possui apenas {idade} anos.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Você pode votar e dirigir,pois já possui {idade} anos.");
                    Console.WriteLine();
                }
                Console.WriteLine("Deseja continuar ? sim/nao");
                resp = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Obrigado por Consultar-se");
        }
    }
}

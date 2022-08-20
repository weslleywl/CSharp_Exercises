using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("------------- Sistema de matrículas -------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Adicionar um aluno ;");
            Console.WriteLine("2 - Listar alunos ; ");
            Console.WriteLine("3 - Remover um aluno ; ");
            Console.WriteLine("0 - Sair ");
            Console.WriteLine();
            List<string> Alunos = new List<string>();
            int cod = int.Parse(Console.ReadLine());
            while (cod != 0)
            {
                Console.Clear();
                if (cod == 1)
                {
                    Console.WriteLine("Digite o nome do aluno : ");
                    Alunos.Add(Console.ReadLine());
                }
                else if(cod == 2)
                {
                    Console.WriteLine("Aqui estao os alunos listados :");
                    foreach(string item in Alunos)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (cod == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("- Listagem dos alunos -");
                    Console.WriteLine("-----------------------");
                    int pos = 1;
                    foreach (string item in Alunos)
                    {
                        Console.WriteLine($"{pos}º {item}");
                        pos++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("1 - Remover um aluno");
                    Console.WriteLine("2 - Remover todos os alunos");
                    Console.Write("Selecione uma opçao :");
                    int cod2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (cod2 == 1)
                    {
                        Console.WriteLine("Selecione a posiçao do aluno a ser removido :");
                        Console.WriteLine("Ex : 1 para primeira posiçao.");
                        Console.Write("cod : ");
                        int del = int.Parse(Console.ReadLine());
                        del = del - 1;
                        Alunos.RemoveAt(del);
                    }
                    else if (cod2 == 2)
                    {
                        Alunos.Clear();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Açao efetuada");
                Console.WriteLine("1 - Adicionar um aluno ;");
                Console.WriteLine("2 - Listar alunos ; ");
                Console.WriteLine("3 - Remover um aluno ; ");
                Console.WriteLine("0 - Sair ");
                Console.Write("Digite novamente o código do serviço desejado : ");
                cod = int.Parse(Console.ReadLine());

            }
        }
    }
}

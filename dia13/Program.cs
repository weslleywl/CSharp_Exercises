using System;
using System.Dynamic;

namespace dia13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ler nome
             ver emquantas aulas ele apareceu
             se sim some as notas e dê a média
             e dizer se foi aprovado ou não
             se ele nao apareceu em todas as aulas perguntas em quais ele foi*/
            decimal resp,n1,n2,n3,med;
            Console.WriteLine("-----Verificação Escolar-----");
            Console.WriteLine();
            Console.WriteLine("Digite seu nome : ");
            string nome = Console.ReadLine();
            Console.WriteLine("O aluno compareceu em quantas avaliações ?");
            Console.WriteLine("1 - uma prova");
            Console.WriteLine("2 - duas provas");
            Console.WriteLine("3 - todas as provas");
            int presenca = Convert.ToInt32(Console.ReadLine());
            if (presenca == 1)
            {
                Console.WriteLine("Quantas segundas chamadas foram feitas ? ");
                Console.WriteLine("1 - uma");
                Console.WriteLine("2 - todas as duas");
                resp = Convert.ToDecimal(Console.ReadLine());
                if (resp == 1)
                {
                    Console.WriteLine("Digite a nota da sua 1° avaliação :");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite a nota da sua 2° avaliação :");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    med = (n1 + n2) / 2;
                    Console.WriteLine("sua média é de " + med);
                    if (med >= 50)
                    {
                        Console.WriteLine("Você foi aprovado...\nParabéns !!");
                    }
                    else
                    {
                        Console.WriteLine("Você foi reprovado...");
                    }

                }
                else if (resp == 2)
                {
                    Console.WriteLine("Digite a nota da sua 1° avaliação :");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite a nota da sua 2° avaliação :");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite a nota da sua 3° avaliação :");
                    n3 = Convert.ToDecimal(Console.ReadLine());
                    med = (n1 + n2 + n3 )/ 3;
                    Console.WriteLine("sua média é de " + Math.Round(med,1));
                    if (med >= 50)
                    {
                        Console.WriteLine("Você foi aprovado...\nParabéns !!");
                    }
                    else
                    {
                        Console.WriteLine("Você foi reprovado...");
                    }
                }
            }
            else if (presenca == 2)
            {
                Console.WriteLine("Foi feita a segunda chamada ?");
                Console.WriteLine("1 - sim / 2 - não");
                resp = Convert.ToDecimal(Console.ReadLine());
                if (resp == 1)
                {
                    Console.WriteLine("Digite a nota da sua 1° avaliação :");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite a nota da sua 2° avaliação :");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite a nota da sua 3° avaliação :");
                    n3 = Convert.ToDecimal(Console.ReadLine());
                    med = (n1 + n2 + n3) / 3;
                    Console.WriteLine("sua média é de " + Math.Round(med, 1));
                    if (med >= 50)
                    {
                        Console.WriteLine("Você foi aprovado...\nParabéns !!");
                    }
                    else
                    {
                        Console.WriteLine("Você foi reprovado...");
                    }
                }
                else
                {
                    Console.WriteLine("Digite a nota da sua 1° avaliação :");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Digite a nota da sua 2° avaliação :");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    med = (n1 + n2) / 2;
                    Console.WriteLine("sua média é de " + med);
                    if (med >= 50)
                    {
                        Console.WriteLine("Você foi aprovado...\nParabéns !!");
                    }
                    else
                    {
                        Console.WriteLine("Você foi reprovado...");
                    }
                }
            }
            else if (presenca == 3)
            {
                Console.WriteLine("Digite a nota da sua 1° avaliação :");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite a nota da sua 2° avaliação :");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Digite a nota da sua 3° avaliação :");
                n3 = Convert.ToDecimal(Console.ReadLine());
                med = (n1 + n2 + n3) / 3;
                Console.WriteLine("sua média é de " + Math.Round(med, 1));
                if (med >= 50)
                {
                    Console.WriteLine("Você foi aprovado...\nParabéns !!");
                }
                else
                {
                    Console.WriteLine("Você foi reprovado...");
                }
            }
            else
            {
                Console.WriteLine("Não entendi sua resposta,insira novamente :");
                presenca = Convert.ToInt32(Console.ReadLine());
                while ((presenca != 1) && (presenca != 2) && (presenca != 3))
                {
                    Console.WriteLine("Não entendi sua resposta,insira novamente :");
                    presenca = Convert.ToInt32(Console.ReadLine());
                }
            }Console.ReadKey();
        }
    }
}

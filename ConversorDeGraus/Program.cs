using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeGraus
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Finally,CurrentScale;int Mistakes = 0;
                Console.WriteLine(",-------------------------------,");
                Console.WriteLine("-BEM VINDO AO CONVERSOR DE GRAUS-");
                Console.WriteLine("'-------------------------------'\n");
                Beginning:
                Console.WriteLine("Digite a letra correspondente à escala do seu ambiente atual :\n");
                Console.WriteLine("exemplo :\n C -> Celsius\n K -> Kelvin\n F -> Farenheit\n\n");
                Console.Write("Escala Atual: ");
                CurrentScale = Console.ReadLine().ToUpper();
                if ((CurrentScale != "C") && (CurrentScale != "F") && (CurrentScale != "K"))
                {
                    Console.Beep();
                    Console.WriteLine("Essa escala nao existe!\n");
                    Console.WriteLine("Pressione Enter para digitar novamente");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Tente uma opçao válida!");
                    Mistakes++;
                    if (Mistakes > 2)
                    {
                        Mistakes:
                        Console.WriteLine("Quer desistir da conversao ?");
                        Console.WriteLine("1 ---> Tentar Novamente");
                        Console.WriteLine("0 ---> Sair da Aplicaçao");
                        Console.Write("Opçao : ");
                        Finally = Console.ReadLine();
                        if (Finally == "1")
                        {
                            goto Beginning;
                        }
                        else if (Finally == "0")
                        {
                            goto End;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("OPÇAO INVÁLIDA !!!");
                            Console.WriteLine("Tente Novamente");
                            goto Mistakes;
                        }
                    }
                    goto Beginning;
                }
                switch (CurrentScale)
                {
                    case ("C"):
                        Celsius C = new Celsius();
                        CelsiusBeginning:
                        Console.WriteLine("A escala Celsius será convertida para qual escala ?\n");
                        Console.WriteLine("C° para ? :\n\n  K -> Kelvin\n  F -> Farenheit\n");
                        Console.Write("Escala Alvo: ");
                        C.Goal = Console.ReadLine().ToUpper();
                        if (C.Goal == "K")
                        {
                            C.CelsiusToKelvin();
                        }
                        else if (C.Goal == "F")
                        {
                            C.CelsiusToFarenheit();
                        }
                        else
                        {
                            Console.Beep();
                            Console.WriteLine("Opçao Inválida!\n");
                            Console.WriteLine("Pressione Enter para digitar novamente");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Tente outra opçao!  Ex:K ou F");
                            goto CelsiusBeginning;
                        }
                        break;
                    case "F":
                        Farenheit F = new Farenheit();
                        FarenheitBeginning:
                        Console.WriteLine("A escala Farenheit será convertida para qual escala ?\n");
                        Console.WriteLine("F° para ? :\n\n  C -> Celsius\n  K -> Kelvin\n");
                        Console.Write("Escala Alvo: ");
                        F.Goal = Console.ReadLine().ToUpper();
                        if (F.Goal == "K")
                        {
                            F.FarenheitToKelvin();
                        }
                        else if (F.Goal == "C")
                        {
                            F.FarenheitToCelsius();
                        }
                        else
                        {
                            Console.Beep();
                            Console.WriteLine("Opçao Inválida!\n");
                            Console.WriteLine("Pressione Enter para digitar novamente");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Tente outra opçao!  Ex:K ou C");
                            goto FarenheitBeginning;
                        }
                        break;
                    case "K":
                        Kelvin K = new Kelvin();
                        KelvinBeginning:
                        Console.WriteLine("A escala Kelvin será convertida para qual escala ?\n");
                        Console.WriteLine("K° para ? :\n\n  C -> Celsius\n  F -> Farenheit\n");
                        Console.Write("Escala Alvo: ");
                        K.Goal = Console.ReadLine().ToUpper();
                        if (K.Goal == "C")
                        {
                            K.KelvinToCelsius();
                        }
                        else if (K.Goal == "F")
                        {
                            K.KelvinToFarenheit();
                        }
                        else
                        {
                            Console.Beep();
                            Console.WriteLine("Opçao Inválida!\n");
                            Console.WriteLine("Pressione Enter para digitar novamente");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Tente outra opçao!  Ex:F ou C");
                            goto KelvinBeginning;
                        }
                        break;
                }
                Console.WriteLine("Pressione Enter para prosseguir");
                Console.ReadKey();
                Console.Clear();
                Ending:
                Console.WriteLine("Oque Deseja fazer ?\n");
                Console.WriteLine("1 ---> Escolher a escala Novamente");
                Console.WriteLine("0 ---> Encerrar a Aplicaçao");
                Console.Write("Opçao : ");
                Finally = Console.ReadLine();
                if (Finally == "1")
                {
                    goto Beginning;
                }
                else if (Finally == "0")
                {
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opçao Inválida!");
                    Console.WriteLine("Tente Novamente");
                    goto Ending;
                }
            End:;
            }
            catch (Exception Error)
            {
                Console.Clear();
                Console.WriteLine("OPS! Parece que voce deu uma Resposta errada!\nDevido à isso ocorreu o seguinte Erro\n");
                Console.WriteLine(Error.Message.ToUpper());
                Console.WriteLine("\n\nOrigem do erro (path):\n");
                Console.WriteLine(Error.StackTrace);
            }
            finally
            {
                Console.WriteLine("Espero ter ajudado,até mais!");
                Console.WriteLine("Pressione Qualquer Tecla para sair . . .");
                Console.ReadKey();
            }
        }
    }
}

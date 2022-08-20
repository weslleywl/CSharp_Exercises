using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            Console.WriteLine("Selecione o tipo de cálculo a ser feito");
            Console.WriteLine("'+' Para Soma");
            Console.WriteLine("'-' Para Subtração");
            Console.WriteLine("'*' Para Multiplicação");
            Console.WriteLine("'/' Para Divisão");
            m.answer = Console.ReadLine();
            Console.WriteLine("Digite seu primeiro número :");
            m.num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu segundo número :");
            m.num2 = Double.Parse(Console.ReadLine());
            m.Operator();
            Console.ReadKey();
        }
    }
}

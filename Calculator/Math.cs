using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math
    {
        public string answer;
        public double num1, num2;
        public void Operator()
        {
            switch (this.answer)
            {
                case "+":
                    Console.WriteLine($"Seu primeiro número escolhido foi o {num1} e o segundo foi {num2}");
                    num1 = num1 + num2;
                    Console.WriteLine($"A soma destes números é igual à {num1}");
                    return;
                    break;
                case "-":
                    Console.WriteLine($"Seu primeiro número escolhido foi o {num1} e o segundo foi {num2}");
                    num1 = num1 - num2;
                    Console.WriteLine($"A subtração destes números é igual à {num1}");
                    return;
                    break;
                case "*":
                    Console.WriteLine($"Seu primeiro número escolhido foi o {num1} e o segundo foi {num2}");
                    num1 = num1 * num2;
                    Console.WriteLine($"A multiplicação destes números é igual à {num1}");
                    return;
                    break;
                case "/":
                    Console.WriteLine($"Seu primeiro número escolhido foi o {num1} e o segundo foi {num2}");
                    num1 = num1 / num2;
                    Console.WriteLine($"A divisão destes números é igual à {num1}");
                    return;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Informe uma operação válida :");
                    break;
            }
        }
    }
}

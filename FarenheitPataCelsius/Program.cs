using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarenheitPataCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[3];
            notas[0] = 3522;
            notas[1] = 4322;
            notas[2] = 1231;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(notas[i]);
            }
            Console.ReadKey();
        }
    }
}

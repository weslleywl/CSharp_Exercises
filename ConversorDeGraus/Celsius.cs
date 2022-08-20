using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeGraus
{
    public class Celsius
    {
        public string Goal { get; set; }
        public double CelsiusDegree { get; set; }

        public void CelsiusToKelvin()
        {//°C+273,15=K
            Console.Write("\nDigite Qual a temperatura atual do seu ambiente : C°");
            CelsiusDegree = double.Parse(Console.ReadLine());
            CelsiusDegree += 273.15;
            Console.WriteLine($"\nA sua temperatura em Kelvin é de : {Math.Round(CelsiusDegree,0)}°K");
        }
        public void CelsiusToFarenheit()
        {//(°C×9/5)+32=°F
            Console.Write("\nDigite Qual a temperatura atual do seu ambiente : C°");
            CelsiusDegree = double.Parse(Console.ReadLine());
            CelsiusDegree = (CelsiusDegree * 9 / 5) + 32;
            Console.WriteLine($"\nA sua temperatura em Farenheint é de : {Math.Round(CelsiusDegree,0)}°F");
        }
    }
}

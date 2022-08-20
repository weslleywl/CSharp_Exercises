using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeGraus
{
    public class Farenheit
    {
        public string Goal { get; set; }
        public double FarenheitDegree { get; set; }

        public void FarenheitToKelvin()
        {//(°F−32)×5/9+273,15=°K
            Console.Write("\nDigite Qual a temperatura atual do seu ambiente : F°");
            FarenheitDegree = double.Parse(Console.ReadLine());
            FarenheitDegree = (FarenheitDegree - 32) * 5 / 9 + 273.15;
            Console.WriteLine($"\nA sua temperatura em Kelvin é de : {Math.Round(FarenheitDegree, 0)}°K");
        }
        public void FarenheitToCelsius()
        {//(°f-32)x5/9=°C
            Console.Write("\nDigite Qual a temperatura atual do seu ambiente : F°");
            FarenheitDegree = double.Parse(Console.ReadLine());
            FarenheitDegree = (FarenheitDegree - 32) * 5 / 9;
            Console.WriteLine($"\nA sua temperatura em Celsius é de : {Math.Round(FarenheitDegree, 0)}°C");
        }
    }
}

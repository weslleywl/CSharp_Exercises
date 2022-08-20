using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeGraus
{
    public class Kelvin
    {
        public string Goal { get; set; }
        public double KelvinDegree { get; set; }

        public void KelvinToFarenheit()
        {//(K−273,15)×9/5+32=°F
            Console.Write("\nDigite Qual a temperatura atual do seu ambiente : K°");
            KelvinDegree = double.Parse(Console.ReadLine());
            KelvinDegree = (KelvinDegree - 273.15) * 9 / 5 + 32;
            Console.WriteLine($"\nA sua temperatura em Farenheit é de : {Math.Round(KelvinDegree, 0)}°F");
        }
        public void KelvinToCelsius()
        {//K−273,15=°C
            Console.Write("\nDigite Qual a temperatura atual do seu ambiente : K°");
            KelvinDegree = double.Parse(Console.ReadLine());
            KelvinDegree = KelvinDegree - 273.15;
            Console.WriteLine($"\nA sua temperatura em Celsius é de : {Math.Round(KelvinDegree, 0)}°C");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = ((celsius * 1.8) +32);
            fahrenheit = Math.Round(fahrenheit, 2);
            Console.WriteLine(fahrenheit);
        }
    }
}

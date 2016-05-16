using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var aria = Math.PI*radius*radius; //	area = Math.PI * r * r
            var perimeter = 2 * Math.PI * radius; //2 * Math.PI * r
            Console.WriteLine("Aria =" + aria);
            Console.WriteLine("Perimeter = "+ perimeter);

        }
    }
}

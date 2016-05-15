using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var aria = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid aria = " + aria);
        }
    }
}

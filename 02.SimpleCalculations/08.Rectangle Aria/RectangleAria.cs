using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Rectangle_Aria
{
    class RectangleAria
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var width = Math.Max(x1, x2) - Math.Min(x1, x2);
            var hight = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area = {0}", (width * hight));
            Console.WriteLine("Perimeter = {0}", 2 * (width + hight));



        }
    }
}

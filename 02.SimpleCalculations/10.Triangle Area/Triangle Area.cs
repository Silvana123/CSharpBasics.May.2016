using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the side of the triangle а = ");
            var a = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the triangle h= ");
            var h = Double.Parse(Console.ReadLine());
            var area = a * h / 2;
            area = Math.Round(area, 2);
            Console.WriteLine("Area of the triangle is: " + area);
            

        }
    }
}

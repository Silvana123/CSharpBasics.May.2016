using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var minNumber = int.MaxValue;
            for (var i = 0; i > count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > minNumber)
                {
                    minNumber = number;
                }

            }
            Console.WriteLine(minNumber);


        }
    }
}

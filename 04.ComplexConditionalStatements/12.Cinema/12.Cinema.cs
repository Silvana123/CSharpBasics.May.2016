﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = Int32.Parse(Console.ReadLine());
            int cols = Int32.Parse(Console.ReadLine());
            double price = 0;

            switch (type)
            {
                case "Premiere": price = 12; break;
                case "Normal": price = 7.5; break;
                case "Discount": price = 5; break;
            }
            Console.WriteLine("{0:F2} leva", price * cols * rows);
        }
    }
}

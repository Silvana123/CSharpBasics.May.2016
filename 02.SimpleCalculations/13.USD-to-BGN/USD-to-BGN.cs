using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usdollar = double.Parse(Console.ReadLine());
            var bgleva = (usdollar * 1.79549);
            bgleva = Math.Round(bgleva, 2);
            Console.WriteLine(bgleva);
        }
    }
}

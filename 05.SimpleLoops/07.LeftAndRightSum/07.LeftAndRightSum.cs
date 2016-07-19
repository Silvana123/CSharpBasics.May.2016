using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (var i = 0; i < count; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < count; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
                

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}",leftSum);
            }
                
            else
            {
                Console.WriteLine("No, diff = {0}" , Math.Abs(rightSum - leftSum));
            }
                
                            

        }
    }
}
